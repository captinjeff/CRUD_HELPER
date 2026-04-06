namespace CRUD_HELPER
{
    partial class Form1
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
            grp_dbinfo = new GroupBox();
            listBox1 = new ListBox();
            splitter1 = new Splitter();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grp_dbinfo.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(grp_dbinfo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 253;
            splitContainer1.TabIndex = 0;
            // 
            // grp_dbinfo
            // 
            grp_dbinfo.Controls.Add(listBox1);
            grp_dbinfo.Controls.Add(splitter1);
            grp_dbinfo.Dock = DockStyle.Fill;
            grp_dbinfo.Location = new Point(0, 0);
            grp_dbinfo.Name = "grp_dbinfo";
            grp_dbinfo.Size = new Size(253, 450);
            grp_dbinfo.TabIndex = 0;
            grp_dbinfo.TabStop = false;
            grp_dbinfo.Text = "ＤＢ정보";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(244, 428);
            listBox1.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 19);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 428);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(543, 300);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 68);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(537, 229);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(537, 49);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // button2
            // 
            button2.Location = new Point(87, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grp_dbinfo.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox grp_dbinfo;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private Splitter splitter1;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}
