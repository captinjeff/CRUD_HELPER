using CRUD_HELPER.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_HELPER.Services
{
    internal class SqlGeneratorService
    {
        public string GenerateSelect(string tableName, List<ColumnInfo> columns)
        {
            var sb = new StringBuilder();

            sb.AppendLine("SELECT");
            sb.AppendLine("    " + string.Join(",\n    ", columns.Select(c => c.ColumnName)));
            sb.AppendLine($"FROM {tableName}");

            var pkCols = columns.Where(c => c.IsPrimaryKey).ToList();
            if (pkCols.Any())
            {
                sb.AppendLine("WHERE 1=1");
                foreach (var pk in pkCols)
                {
                    sb.AppendLine($"  AND {pk.ColumnName} = @{pk.ColumnName}");
                }
            }

            return sb.ToString();
        }

        public string GenerateInsert(string tableName, List<ColumnInfo> columns)
        {
            var insertCols = columns;

            var sb = new StringBuilder();
            sb.AppendLine($"INSERT INTO {tableName}");
            sb.AppendLine("(");
            sb.AppendLine("    " + string.Join(",\n    ", insertCols.Select(c => c.ColumnName)));
            sb.AppendLine(")");
            sb.AppendLine("VALUES");
            sb.AppendLine("(");
            sb.AppendLine("    " + string.Join(",\n    ", insertCols.Select(c => "@" + c.ColumnName)));
            sb.AppendLine(");");

            return sb.ToString();
        }

        public string GenerateUpdate(string tableName, List<ColumnInfo> columns)
        {
            var pkCols = columns.Where(c => c.IsPrimaryKey).ToList();
            var normalCols = columns.Where(c => !c.IsPrimaryKey).ToList();

            var sb = new StringBuilder();
            sb.AppendLine($"UPDATE {tableName}");
            sb.AppendLine("SET");
            sb.AppendLine("    " + string.Join(",\n    ", normalCols.Select(c => $"{c.ColumnName} = @{c.ColumnName}")));

            if (pkCols.Any())
            {
                sb.AppendLine("WHERE 1=1");
                foreach (var pk in pkCols)
                {
                    sb.AppendLine($"  AND {pk.ColumnName} = @{pk.ColumnName}");
                }
            }
            else
            {
                sb.AppendLine("-- PK가 없어서 WHERE 절 자동 생성 불가");
            }

            sb.AppendLine(";");
            return sb.ToString();
        }

        public string GenerateDelete(string tableName, List<ColumnInfo> columns)
        {
            var pkCols = columns.Where(c => c.IsPrimaryKey).ToList();

            var sb = new StringBuilder();
            sb.AppendLine($"DELETE FROM {tableName}");

            if (pkCols.Any())
            {
                sb.AppendLine("WHERE 1=1");
                foreach (var pk in pkCols)
                {
                    sb.AppendLine($"  AND {pk.ColumnName} = @{pk.ColumnName}");
                }
            }
            else
            {
                sb.AppendLine("-- PK가 없어서 WHERE 절 자동 생성 불가");
            }

            sb.AppendLine(";");
            return sb.ToString();
        }
    }
}
