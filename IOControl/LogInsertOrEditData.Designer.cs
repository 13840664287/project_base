namespace IOControl
{
    partial class LogInsertOrEditData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInsertOrEditData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_strtemplate = new System.Windows.Forms.TextBox();
            this.txt_logkey = new System.Windows.Forms.TextBox();
            this.txt_loname = new System.Windows.Forms.TextBox();
            this.lable_loname = new System.Windows.Forms.Label();
            this.label_strtemplate = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.sbtn_insert);
            this.groupBox1.Controls.Add(this.sbtn_cancel);
            this.groupBox1.Controls.Add(this.txt_strtemplate);
            this.groupBox1.Controls.Add(this.txt_logkey);
            this.groupBox1.Controls.Add(this.txt_loname);
            this.groupBox1.Controls.Add(this.lable_loname);
            this.groupBox1.Controls.Add(this.label_strtemplate);
            this.groupBox1.Controls.Add(this.label_key);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // sbtn_insert
            // 
            this.sbtn_insert.Location = new System.Drawing.Point(89, 296);
            this.sbtn_insert.Name = "sbtn_insert";
            this.sbtn_insert.Size = new System.Drawing.Size(121, 49);
            this.sbtn_insert.TabIndex = 36;
            this.sbtn_insert.Text = "添加";
            this.sbtn_insert.Click += new System.EventHandler(this.sbtn_insert_Click);
            // 
            // sbtn_cancel
            // 
            this.sbtn_cancel.Location = new System.Drawing.Point(445, 296);
            this.sbtn_cancel.Name = "sbtn_cancel";
            this.sbtn_cancel.Size = new System.Drawing.Size(121, 49);
            this.sbtn_cancel.TabIndex = 35;
            this.sbtn_cancel.Text = "取消";
            this.sbtn_cancel.Click += new System.EventHandler(this.sbtn_cancel_Click);
            // 
            // txt_strtemplate
            // 
            this.txt_strtemplate.Location = new System.Drawing.Point(175, 227);
            this.txt_strtemplate.Name = "txt_strtemplate";
            this.txt_strtemplate.Size = new System.Drawing.Size(409, 28);
            this.txt_strtemplate.TabIndex = 34;
            // 
            // txt_logkey
            // 
            this.txt_logkey.Location = new System.Drawing.Point(175, 173);
            this.txt_logkey.Name = "txt_logkey";
            this.txt_logkey.Size = new System.Drawing.Size(409, 28);
            this.txt_logkey.TabIndex = 29;
            // 
            // txt_loname
            // 
            this.txt_loname.Location = new System.Drawing.Point(175, 117);
            this.txt_loname.Name = "txt_loname";
            this.txt_loname.Size = new System.Drawing.Size(409, 28);
            this.txt_loname.TabIndex = 28;
            // 
            // lable_loname
            // 
            this.lable_loname.AutoSize = true;
            this.lable_loname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lable_loname.Location = new System.Drawing.Point(86, 120);
            this.lable_loname.Name = "lable_loname";
            this.lable_loname.Size = new System.Drawing.Size(53, 18);
            this.lable_loname.TabIndex = 27;
            this.lable_loname.Text = "名称:";
            // 
            // label_strtemplate
            // 
            this.label_strtemplate.AutoSize = true;
            this.label_strtemplate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_strtemplate.Location = new System.Drawing.Point(50, 230);
            this.label_strtemplate.Name = "label_strtemplate";
            this.label_strtemplate.Size = new System.Drawing.Size(89, 18);
            this.label_strtemplate.TabIndex = 23;
            this.label_strtemplate.Text = "日志模板:";
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_key.Location = new System.Drawing.Point(95, 176);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(44, 18);
            this.label_key.TabIndex = 22;
            this.label_key.Text = "key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(227, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "日志配置添加信息功能";
            // 
            // LogInsertOrEditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 488);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogInsertOrEditData";
            this.Text = "日志配置添加";
            this.Load += new System.EventHandler(this.LogInsertOrEditData_Load);
            this.Resize += new System.EventHandler(this.LogInsertOrEditData_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.SimpleButton sbtn_insert;
        private DevExpress.XtraEditors.SimpleButton sbtn_cancel;
        public System.Windows.Forms.TextBox txt_strtemplate;
        public System.Windows.Forms.TextBox txt_logkey;
        public System.Windows.Forms.TextBox txt_loname;
        private System.Windows.Forms.Label lable_loname;
        private System.Windows.Forms.Label label_strtemplate;
        private System.Windows.Forms.Label label_key;
        public System.Windows.Forms.Label label1;
    }
}