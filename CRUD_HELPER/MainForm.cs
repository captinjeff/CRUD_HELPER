using CRUD_HELPER.Model;
using CRUD_HELPER.Models;
using CRUD_HELPER.Services;
using Npgsql;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static CRUD_HELPER.Model.DbConnectionInfo;


namespace CRUD_HELPER
{
    public partial class MainForm : Form
    {
        private readonly IDbSchemaService _schemaService;
        private readonly SqlGeneratorService _sqlGenerator;
        private DbConnectionInfo _connInfo;
        private List<ColumnInfo> _currentColumns;
        private string _currentTableName;
        private List<BasicCodeItem> _basicCodes = new List<BasicCodeItem>();

        public MainForm()
        {
            InitializeComponent();

            _schemaService = new PostgresSchemaService();
            _sqlGenerator = new SqlGeneratorService();

            string filePath = Path.Combine(Application.StartupPath, "Config", "BasicCode.csv");
            _basicCodes = CsvCodeLoader.LoadBasicCodes(filePath);

            //BindCombo(cboDbInfo, "DB_TYPE");
            BindCombo(CboDbOp, "parameter");
        }
        private void BindCombo(ComboBox combo, string groupCd)
        {
            var list = _basicCodes
                .Where(x => x.GroupCd == groupCd && x.UseYn == "Y")
                .OrderBy(x => x.SortNo)
                .ToList();

            combo.DataSource = list;
            combo.DisplayMember = "CodeNm";
            combo.ValueMember = "Code";
        }

        private void cboDbInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private DbConnectionInfo GetConnectionInfoFromUI()
        {
            return new DbConnectionInfo
            {
                DbType = "PostgreSQL",
                Host = "10.7.114.41",
                Port = "5432",
                Database = "avoidm",
                UserId = "hjp",
                Password = "wovwlsh96"
            };
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _connInfo = GetConnectionInfoFromUI();
                var tables = _schemaService.GetTables(_connInfo);

                lstTables.Items.Clear();
                foreach (var table in tables)
                {
                    lstTables.Items.Add(table);
                }

                MessageBox.Show("연결 및 테이블 조회 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
        }

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstTables.SelectedItem == null) return;

                _currentTableName = lstTables.SelectedItem.ToString();
                _currentColumns = _schemaService.GetColumns(_connInfo, _currentTableName);

                dgvColumns.DataSource = null;
                dgvColumns.DataSource = _currentColumns;
            }
            catch (Exception ex)
            {
                MessageBox.Show("컬럼 조회 오류: " + ex.Message);
            }
        }

        private void btnSelectSql_Click(object sender, EventArgs e)
        {
            txtSql.Text = _sqlGenerator.GenerateSelect(_currentTableName, _currentColumns);
        }

        private void btnInsertSql_Click(object sender, EventArgs e)
        {
            txtSql.Text = _sqlGenerator.GenerateInsert(_currentTableName, _currentColumns);
        }

        private void btnUpdateSql_Click(object sender, EventArgs e)
        {
            txtSql.Text = _sqlGenerator.GenerateUpdate(_currentTableName, _currentColumns);
        }

        private void btnDeleteSql_Click(object sender, EventArgs e)
        {
            txtSql.Text = _sqlGenerator.GenerateDelete(_currentTableName, _currentColumns);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSql.Text))
                {
                    MessageBox.Show("복사할 SQL이 없습니다.");
                    return;
                }

                string tableName = string.IsNullOrWhiteSpace(_currentTableName) ? "sample_table" : _currentTableName;
                string mybatisSql = ConvertToMyBatisXml(txtSql.Text, tableName);

                Clipboard.SetText(mybatisSql);
                MessageBox.Show("MyBatis 형식으로 복사 완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show("복사 오류: " + ex.Message);
            }
        }

        private string ConvertAtParamToMyBatisParam(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
                return sql;

            return System.Text.RegularExpressions.Regex.Replace(
                sql,
                @"@([A-Za-z0-9_]+)",
                "#{$1}"
            );
        }

        private string ConvertToMyBatisXml(string sql, string tableName)
        {
            string trimmedSql = sql.Trim();


            if (CboDbOp.SelectedValue.Equals("1"))
            {
                trimmedSql = ConvertAtParamToMyBatisParam(trimmedSql);
            }
            

            string commandType = GetSqlCommandType(trimmedSql);

            string id = GetDefaultMyBatisId(commandType, tableName);
            string parameterType = "map";
            string resultType = "map";

            var sb = new StringBuilder();

            switch (commandType)
            {
                case "SELECT":
                    sb.AppendLine($"<select id=\"{id}\" parameterType=\"{parameterType}\" resultType=\"{resultType}\">");
                    sb.AppendLine("    <![CDATA[");
                    sb.AppendLine(AddIndent(trimmedSql, 2));
                    sb.AppendLine("    ]]>");
                    sb.AppendLine("</select>");
                    break;

                case "INSERT":
                    sb.AppendLine($"<insert id=\"{id}\" parameterType=\"{parameterType}\">");
                    sb.AppendLine("    <![CDATA[");
                    sb.AppendLine(AddIndent(trimmedSql, 2));
                    sb.AppendLine("    ]]>");
                    sb.AppendLine("</insert>");
                    break;

                case "UPDATE":
                    sb.AppendLine($"<update id=\"{id}\" parameterType=\"{parameterType}\">");
                    sb.AppendLine("    <![CDATA[");
                    sb.AppendLine(AddIndent(trimmedSql, 2));
                    sb.AppendLine("    ]]>");
                    sb.AppendLine("</update>");
                    break;

                case "DELETE":
                    sb.AppendLine($"<delete id=\"{id}\" parameterType=\"{parameterType}\">");
                    sb.AppendLine("    <![CDATA[");
                    sb.AppendLine(AddIndent(trimmedSql, 2));
                    sb.AppendLine("    ]]>");
                    sb.AppendLine("</delete>");
                    break;

                default:
                    sb.AppendLine("<!-- SQL 타입을 판별할 수 없습니다. -->");
                    sb.AppendLine("<select id=\"unknownQuery\" parameterType=\"map\" resultType=\"map\">");
                    sb.AppendLine("    <![CDATA[");
                    sb.AppendLine(AddIndent(trimmedSql, 2));
                    sb.AppendLine("    ]]>");
                    sb.AppendLine("</select>");
                    break;
            }

            return sb.ToString();
        }

        private string GetSqlCommandType(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
                return "";

            string upperSql = sql.TrimStart().ToUpper();

            if (upperSql.StartsWith("SELECT") || upperSql.StartsWith("WITH"))
                return "SELECT";
            if (upperSql.StartsWith("INSERT"))
                return "INSERT";
            if (upperSql.StartsWith("UPDATE"))
                return "UPDATE";
            if (upperSql.StartsWith("DELETE"))
                return "DELETE";

            return "";
        }

        private string GetDefaultMyBatisId(string commandType, string tableName)
        {
            string pascalName = ToPascalCase(tableName);

            switch (commandType)
            {
                case "SELECT":
                    return $"select{pascalName}";
                case "INSERT":
                    return $"insert{pascalName}";
                case "UPDATE":
                    return $"update{pascalName}";
                case "DELETE":
                    return $"delete{pascalName}";
                default:
                    return "unknownQuery";
            }
        }

        private string ToPascalCase(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";

            var parts = text.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();

            foreach (var part in parts)
            {
                if (part.Length == 1)
                    sb.Append(part.ToUpper());
                else
                    sb.Append(char.ToUpper(part[0]) + part.Substring(1).ToLower());
            }

            return sb.ToString();
        }

        private string AddIndent(string text, int indentLevel)
        {
            string indent = new string(' ', indentLevel * 4);
            var lines = text.Replace("\r\n", "\n").Split('\n');

            var sb = new StringBuilder();
            foreach (var line in lines)
            {
                sb.AppendLine(indent + line);
            }

            return sb.ToString().TrimEnd();
        }

        private void ExecuteSqlAndBind(object sender, EventArgs e)
        {
            try
            {
                if (_connInfo == null)
                {
                    MessageBox.Show("먼저 DB 연결 정보를 설정하세요.");
                    return;
                }

                var sql = txtSql.Text?.Trim();

                if (string.IsNullOrWhiteSpace(sql))
                {
                    MessageBox.Show("실행할 SQL이 없습니다.");
                    return;
                }

                using (var conn = new NpgsqlConnection(_connInfo.GetConnectionString()))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // SELECT 여부 단순 판별
                        var firstWord = sql.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                           .FirstOrDefault()?.ToUpper();

                        if (firstWord == "SELECT" || firstWord == "WITH")
                        {
                            using (var adapter = new NpgsqlDataAdapter(cmd))
                            {
                                var dt = new DataTable();
                                adapter.Fill(dt);

                                dgvResult.DataSource = null;
                                dgvResult.AutoGenerateColumns = true;
                                dgvResult.DataSource = dt;

                                MessageBox.Show($"조회 완료: {dt.Rows.Count}건");
                            }
                        }
                        else
                        {
                            int affected = cmd.ExecuteNonQuery();

                            dgvResult.DataSource = null;
                            MessageBox.Show($"실행 완료: {affected}건 처리됨");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL 실행 오류: " + ex.Message);
            }
        }
    }
}
