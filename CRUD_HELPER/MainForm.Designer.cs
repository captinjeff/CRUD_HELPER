namespace CRUD_HELPER
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            grp_dbList = new GroupBox();
            lstTables = new ListBox();
            splitter1 = new Splitter();
            grp_dbInfo = new GroupBox();
            dgvColumns = new DataGridView();
            splitContainer2 = new SplitContainer();
            txtSql = new RichTextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            CboDbOp = new ComboBox();
            btn_copy = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_connect = new Button();
            btn_select = new Button();
            btn_Insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            grp_data = new GroupBox();
            panel2 = new Panel();
            dgvResult = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_execute = new Button();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            grp_dbList.SuspendLayout();
            grp_dbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            grp_data.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1218, 637);
            splitContainer1.SplitterDistance = 328;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(grp_dbList);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(grp_dbInfo);
            splitContainer3.Size = new Size(328, 637);
            splitContainer3.SplitterDistance = 327;
            splitContainer3.TabIndex = 0;
            // 
            // grp_dbList
            // 
            grp_dbList.Controls.Add(lstTables);
            grp_dbList.Controls.Add(splitter1);
            grp_dbList.Dock = DockStyle.Fill;
            grp_dbList.Location = new Point(0, 0);
            grp_dbList.Name = "grp_dbList";
            grp_dbList.Size = new Size(328, 327);
            grp_dbList.TabIndex = 1;
            grp_dbList.TabStop = false;
            grp_dbList.Text = "DB List";
            // 
            // lstTables
            // 
            lstTables.Dock = DockStyle.Fill;
            lstTables.FormattingEnabled = true;
            lstTables.Location = new Point(6, 19);
            lstTables.Name = "lstTables";
            lstTables.Size = new Size(319, 305);
            lstTables.TabIndex = 3;
            lstTables.SelectedIndexChanged += lstTables_SelectedIndexChanged;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 19);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 305);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // grp_dbInfo
            // 
            grp_dbInfo.Controls.Add(dgvColumns);
            grp_dbInfo.Dock = DockStyle.Fill;
            grp_dbInfo.Location = new Point(0, 0);
            grp_dbInfo.Name = "grp_dbInfo";
            grp_dbInfo.Size = new Size(328, 306);
            grp_dbInfo.TabIndex = 0;
            grp_dbInfo.TabStop = false;
            grp_dbInfo.Text = "DB INFO";
            // 
            // dgvColumns
            // 
            dgvColumns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColumns.Dock = DockStyle.Fill;
            dgvColumns.Location = new Point(3, 19);
            dgvColumns.Name = "dgvColumns";
            dgvColumns.Size = new Size(322, 284);
            dgvColumns.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtSql);
            splitContainer2.Panel1.Controls.Add(flowLayoutPanel3);
            splitContainer2.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(grp_data);
            splitContainer2.Size = new Size(886, 637);
            splitContainer2.SplitterDistance = 399;
            splitContainer2.TabIndex = 0;
            // 
            // txtSql
            // 
            txtSql.Dock = DockStyle.Fill;
            txtSql.Location = new Point(0, 64);
            txtSql.Name = "txtSql";
            txtSql.Size = new Size(886, 335);
            txtSql.TabIndex = 8;
            txtSql.Text = "";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(CboDbOp);
            flowLayoutPanel3.Controls.Add(btn_copy);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(0, 30);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(886, 34);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // CboDbOp
            // 
            CboDbOp.FormattingEnabled = true;
            CboDbOp.Location = new Point(3, 3);
            CboDbOp.Name = "CboDbOp";
            CboDbOp.Size = new Size(121, 23);
            CboDbOp.TabIndex = 7;
            // 
            // btn_copy
            // 
            btn_copy.Location = new Point(130, 3);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new Size(75, 23);
            btn_copy.TabIndex = 5;
            btn_copy.Text = "COPY";
            btn_copy.UseVisualStyleBackColor = true;
            btn_copy.Click += btnCopy_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_connect);
            flowLayoutPanel1.Controls.Add(btn_select);
            flowLayoutPanel1.Controls.Add(btn_Insert);
            flowLayoutPanel1.Controls.Add(btn_update);
            flowLayoutPanel1.Controls.Add(btn_delete);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(886, 30);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(3, 3);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(75, 23);
            btn_connect.TabIndex = 0;
            btn_connect.Text = "CONNECT";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btnConnect_Click;
            // 
            // btn_select
            // 
            btn_select.Location = new Point(84, 3);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(75, 23);
            btn_select.TabIndex = 1;
            btn_select.Text = "SELECT";
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btnSelectSql_Click;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(165, 3);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(75, 23);
            btn_Insert.TabIndex = 2;
            btn_Insert.Text = "INSERT";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btnInsertSql_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(246, 3);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 3;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btnUpdateSql_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(327, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btnDeleteSql_Click;
            // 
            // grp_data
            // 
            grp_data.Controls.Add(panel2);
            grp_data.Controls.Add(flowLayoutPanel2);
            grp_data.Dock = DockStyle.Fill;
            grp_data.Location = new Point(0, 0);
            grp_data.Name = "grp_data";
            grp_data.Size = new Size(886, 234);
            grp_data.TabIndex = 9;
            grp_data.TabStop = false;
            grp_data.Text = "Data";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvResult);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 184);
            panel2.TabIndex = 1;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Dock = DockStyle.Fill;
            dgvResult.Location = new Point(0, 0);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(880, 184);
            dgvResult.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn_execute);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(880, 28);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btn_execute
            // 
            btn_execute.Location = new Point(3, 3);
            btn_execute.Name = "btn_execute";
            btn_execute.Size = new Size(75, 23);
            btn_execute.TabIndex = 0;
            btn_execute.Text = "execute";
            btn_execute.UseVisualStyleBackColor = true;
            btn_execute.Click += ExecuteSqlAndBind;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 637);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            grp_dbList.ResumeLayout(false);
            grp_dbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvColumns).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            grp_data.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private SplitContainer splitContainer2;
        private GroupBox grp_data;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn_execute;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_connect;
        private Button btn_select;
        private Button btn_Insert;
        private Button btn_update;
        private Button btn_delete;
        private RichTextBox txtSql;
        private DataGridView dgvColumns;
        private SplitContainer splitContainer3;
        private GroupBox grp_dbList;
        private ListBox lstTables;
        private Splitter splitter1;
        private GroupBox grp_dbInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvResult;
        private Button btn_copy;
        private FlowLayoutPanel flowLayoutPanel3;
        private ComboBox CboDbOp;
    }
}
