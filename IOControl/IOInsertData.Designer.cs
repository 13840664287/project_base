namespace IOControl
{
    partial class IOInsertData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IOInsertData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbox_control = new System.Windows.Forms.ComboBox();
            this.cmbox_iotype = new System.Windows.Forms.ComboBox();
            this.sbtn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_falsetext = new System.Windows.Forms.TextBox();
            this.txt_addr1 = new System.Windows.Forms.TextBox();
            this.txt_addr2 = new System.Windows.Forms.TextBox();
            this.txt_truetext = new System.Windows.Forms.TextBox();
            this.txt_ioname = new System.Windows.Forms.TextBox();
            this.lable_ioname = new System.Windows.Forms.Label();
            this.label_addr1 = new System.Windows.Forms.Label();
            this.label_control = new System.Windows.Forms.Label();
            this.iotype = new System.Windows.Forms.Label();
            this.label_falsetext = new System.Windows.Forms.Label();
            this.label_truetext = new System.Windows.Forms.Label();
            this.label_addr2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cmbox_control);
            this.groupBox1.Controls.Add(this.cmbox_iotype);
            this.groupBox1.Controls.Add(this.sbtn_insert);
            this.groupBox1.Controls.Add(this.sbtn_cancel);
            this.groupBox1.Controls.Add(this.txt_falsetext);
            this.groupBox1.Controls.Add(this.txt_addr1);
            this.groupBox1.Controls.Add(this.txt_addr2);
            this.groupBox1.Controls.Add(this.txt_truetext);
            this.groupBox1.Controls.Add(this.txt_ioname);
            this.groupBox1.Controls.Add(this.lable_ioname);
            this.groupBox1.Controls.Add(this.label_addr1);
            this.groupBox1.Controls.Add(this.label_control);
            this.groupBox1.Controls.Add(this.iotype);
            this.groupBox1.Controls.Add(this.label_falsetext);
            this.groupBox1.Controls.Add(this.label_truetext);
            this.groupBox1.Controls.Add(this.label_addr2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(76, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 611);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbox_control
            // 
            this.cmbox_control.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_control.FormattingEnabled = true;
            this.cmbox_control.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbox_control.Location = new System.Drawing.Point(233, 342);
            this.cmbox_control.Name = "cmbox_control";
            this.cmbox_control.Size = new System.Drawing.Size(409, 26);
            this.cmbox_control.TabIndex = 38;
            // 
            // cmbox_iotype
            // 
            this.cmbox_iotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_iotype.FormattingEnabled = true;
            this.cmbox_iotype.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbox_iotype.Location = new System.Drawing.Point(233, 285);
            this.cmbox_iotype.Name = "cmbox_iotype";
            this.cmbox_iotype.Size = new System.Drawing.Size(409, 26);
            this.cmbox_iotype.TabIndex = 37;
            // 
            // sbtn_insert
            // 
            this.sbtn_insert.Location = new System.Drawing.Point(234, 534);
            this.sbtn_insert.Name = "sbtn_insert";
            this.sbtn_insert.Size = new System.Drawing.Size(121, 49);
            this.sbtn_insert.TabIndex = 36;
            this.sbtn_insert.Text = "添加";
            this.sbtn_insert.Click += new System.EventHandler(this.sbtn_insert_Click);
            // 
            // sbtn_cancel
            // 
            this.sbtn_cancel.Location = new System.Drawing.Point(491, 534);
            this.sbtn_cancel.Name = "sbtn_cancel";
            this.sbtn_cancel.Size = new System.Drawing.Size(121, 49);
            this.sbtn_cancel.TabIndex = 35;
            this.sbtn_cancel.Text = "取消";
            this.sbtn_cancel.Click += new System.EventHandler(this.sbtn_cancel_Click);
            // 
            // txt_falsetext
            // 
            this.txt_falsetext.Location = new System.Drawing.Point(234, 227);
            this.txt_falsetext.Name = "txt_falsetext";
            this.txt_falsetext.Size = new System.Drawing.Size(409, 28);
            this.txt_falsetext.TabIndex = 34;
            // 
            // txt_addr1
            // 
            this.txt_addr1.Location = new System.Drawing.Point(233, 402);
            this.txt_addr1.Name = "txt_addr1";
            this.txt_addr1.Size = new System.Drawing.Size(409, 28);
            this.txt_addr1.TabIndex = 33;
            // 
            // txt_addr2
            // 
            this.txt_addr2.Location = new System.Drawing.Point(233, 468);
            this.txt_addr2.Name = "txt_addr2";
            this.txt_addr2.Size = new System.Drawing.Size(409, 28);
            this.txt_addr2.TabIndex = 31;
            // 
            // txt_truetext
            // 
            this.txt_truetext.Location = new System.Drawing.Point(234, 173);
            this.txt_truetext.Name = "txt_truetext";
            this.txt_truetext.Size = new System.Drawing.Size(409, 28);
            this.txt_truetext.TabIndex = 29;
            // 
            // txt_ioname
            // 
            this.txt_ioname.Location = new System.Drawing.Point(234, 117);
            this.txt_ioname.Name = "txt_ioname";
            this.txt_ioname.Size = new System.Drawing.Size(409, 28);
            this.txt_ioname.TabIndex = 28;
            // 
            // lable_ioname
            // 
            this.lable_ioname.AutoSize = true;
            this.lable_ioname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lable_ioname.Location = new System.Drawing.Point(140, 120);
            this.lable_ioname.Name = "lable_ioname";
            this.lable_ioname.Size = new System.Drawing.Size(53, 18);
            this.lable_ioname.TabIndex = 27;
            this.lable_ioname.Text = "名称:";
            // 
            // label_addr1
            // 
            this.label_addr1.AutoSize = true;
            this.label_addr1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_addr1.Location = new System.Drawing.Point(113, 405);
            this.label_addr1.Name = "label_addr1";
            this.label_addr1.Size = new System.Drawing.Size(98, 18);
            this.label_addr1.TabIndex = 26;
            this.label_addr1.Text = "控制地址1:";
            // 
            // label_control
            // 
            this.label_control.AutoSize = true;
            this.label_control.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_control.Location = new System.Drawing.Point(140, 345);
            this.label_control.Name = "label_control";
            this.label_control.Size = new System.Drawing.Size(71, 18);
            this.label_control.TabIndex = 25;
            this.label_control.Text = "控制源:";
            // 
            // iotype
            // 
            this.iotype.AutoSize = true;
            this.iotype.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.iotype.Location = new System.Drawing.Point(140, 288);
            this.iotype.Name = "iotype";
            this.iotype.Size = new System.Drawing.Size(53, 18);
            this.iotype.TabIndex = 24;
            this.iotype.Text = "类型:";
            // 
            // label_falsetext
            // 
            this.label_falsetext.AutoSize = true;
            this.label_falsetext.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_falsetext.Location = new System.Drawing.Point(140, 230);
            this.label_falsetext.Name = "label_falsetext";
            this.label_falsetext.Size = new System.Drawing.Size(71, 18);
            this.label_falsetext.TabIndex = 23;
            this.label_falsetext.Text = "关文字:";
            // 
            // label_truetext
            // 
            this.label_truetext.AutoSize = true;
            this.label_truetext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_truetext.Location = new System.Drawing.Point(140, 176);
            this.label_truetext.Name = "label_truetext";
            this.label_truetext.Size = new System.Drawing.Size(71, 18);
            this.label_truetext.TabIndex = 22;
            this.label_truetext.Text = "开文字:";
            // 
            // label_addr2
            // 
            this.label_addr2.AutoSize = true;
            this.label_addr2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_addr2.Location = new System.Drawing.Point(113, 471);
            this.label_addr2.Name = "label_addr2";
            this.label_addr2.Size = new System.Drawing.Size(98, 18);
            this.label_addr2.TabIndex = 21;
            this.label_addr2.Text = "控制地址2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(306, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "I/O添加信息功能";
            // 
            // IOInsertData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(959, 709);
            this.Controls.Add(this.groupBox1);
            this.Name = "IOInsertData";
            this.Text = "IO信息添加";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IOInsertData_FormClosed);
            this.Load += new System.EventHandler(this.IOInsertData_Load);
            this.Resize += new System.EventHandler(this.IOInsertData_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton sbtn_cancel;
        private System.Windows.Forms.Label lable_ioname;
        private System.Windows.Forms.Label label_addr1;
        private System.Windows.Forms.Label label_control;
        private System.Windows.Forms.Label iotype;
        private System.Windows.Forms.Label label_falsetext;
        private System.Windows.Forms.Label label_truetext;
        private System.Windows.Forms.Label label_addr2;
        public System.Windows.Forms.TextBox txt_falsetext;
        public System.Windows.Forms.TextBox txt_addr1;
        public System.Windows.Forms.TextBox txt_addr2;
        public System.Windows.Forms.TextBox txt_truetext;
        public System.Windows.Forms.TextBox txt_ioname;
        public System.Windows.Forms.ComboBox cmbox_iotype;
        public System.Windows.Forms.ComboBox cmbox_control;
        public DevExpress.XtraEditors.SimpleButton sbtn_insert;
        public System.Windows.Forms.Label label1;
    }
}