namespace ZYExcel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_DirPath = new System.Windows.Forms.RichTextBox();
            this.btn_ChoseDir = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ColName = new System.Windows.Forms.TextBox();
            this.btn_ConfirmDel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "要操作的表格路径：";
            // 
            // rtb_DirPath
            // 
            this.rtb_DirPath.Location = new System.Drawing.Point(153, 23);
            this.rtb_DirPath.Name = "rtb_DirPath";
            this.rtb_DirPath.ReadOnly = true;
            this.rtb_DirPath.Size = new System.Drawing.Size(263, 51);
            this.rtb_DirPath.TabIndex = 1;
            this.rtb_DirPath.Text = "";
            // 
            // btn_ChoseDir
            // 
            this.btn_ChoseDir.Location = new System.Drawing.Point(448, 21);
            this.btn_ChoseDir.Name = "btn_ChoseDir";
            this.btn_ChoseDir.Size = new System.Drawing.Size(109, 27);
            this.btn_ChoseDir.TabIndex = 2;
            this.btn_ChoseDir.Text = "选择文件路径";
            this.btn_ChoseDir.UseVisualStyleBackColor = true;
            this.btn_ChoseDir.Click += new System.EventHandler(this.btn_ChoseDir_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(22, 94);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(535, 357);
            this.treeView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.btn_ChoseDir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtb_DirPath);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 460);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ConfirmDel);
            this.groupBox2.Controls.Add(this.tb_ColName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(592, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "删除操作";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "列名：";
            // 
            // tb_ColName
            // 
            this.tb_ColName.Location = new System.Drawing.Point(52, 22);
            this.tb_ColName.Name = "tb_ColName";
            this.tb_ColName.Size = new System.Drawing.Size(216, 23);
            this.tb_ColName.TabIndex = 1;
            // 
            // btn_ConfirmDel
            // 
            this.btn_ConfirmDel.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ConfirmDel.Location = new System.Drawing.Point(162, 57);
            this.btn_ConfirmDel.Name = "btn_ConfirmDel";
            this.btn_ConfirmDel.Size = new System.Drawing.Size(105, 26);
            this.btn_ConfirmDel.TabIndex = 2;
            this.btn_ConfirmDel.Text = "确认删除";
            this.btn_ConfirmDel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(592, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 354);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "业绩表";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "表格导出";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_DirPath;
        private System.Windows.Forms.Button btn_ChoseDir;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ConfirmDel;
        private System.Windows.Forms.TextBox tb_ColName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

