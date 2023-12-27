namespace IOControl
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcontrol_t_ios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ioname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.truetext = new DevExpress.XtraGrid.Columns.GridColumn();
            this.falsetext = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iotype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.control = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addr2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.operate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_delete1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sbtn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_import = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcontrol_t_ios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // gcontrol_t_ios
            // 
            this.gcontrol_t_ios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gcontrol_t_ios.BackgroundImage")));
            this.gcontrol_t_ios.Location = new System.Drawing.Point(0, 50);
            this.gcontrol_t_ios.MainView = this.gridView1;
            this.gcontrol_t_ios.Name = "gcontrol_t_ios";
            this.gcontrol_t_ios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_edit,
            this.btn_delete,
            this.btn_delete1});
            this.gcontrol_t_ios.Size = new System.Drawing.Size(1156, 630);
            this.gcontrol_t_ios.TabIndex = 0;
            this.gcontrol_t_ios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ioname,
            this.truetext,
            this.falsetext,
            this.id,
            this.iotype,
            this.control,
            this.addr1,
            this.addr2,
            this.operate,
            this.operate1});
            this.gridView1.GridControl = this.gcontrol_t_ios;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ioname
            // 
            this.ioname.Caption = "名称";
            this.ioname.Name = "ioname";
            this.ioname.OptionsColumn.AllowEdit = false;
            this.ioname.OptionsColumn.ReadOnly = true;
            this.ioname.Visible = true;
            this.ioname.VisibleIndex = 0;
            // 
            // truetext
            // 
            this.truetext.Caption = "开文字";
            this.truetext.Name = "truetext";
            this.truetext.OptionsColumn.AllowEdit = false;
            this.truetext.OptionsColumn.ReadOnly = true;
            this.truetext.Visible = true;
            this.truetext.VisibleIndex = 1;
            // 
            // falsetext
            // 
            this.falsetext.Caption = "关文字";
            this.falsetext.Name = "falsetext";
            this.falsetext.OptionsColumn.AllowEdit = false;
            this.falsetext.OptionsColumn.ReadOnly = true;
            this.falsetext.Visible = true;
            this.falsetext.VisibleIndex = 2;
            // 
            // id
            // 
            this.id.Caption = "序号";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.OptionsColumn.ReadOnly = true;
            // 
            // iotype
            // 
            this.iotype.Caption = "类型";
            this.iotype.Name = "iotype";
            this.iotype.OptionsColumn.AllowEdit = false;
            this.iotype.OptionsColumn.ReadOnly = true;
            this.iotype.Visible = true;
            this.iotype.VisibleIndex = 3;
            // 
            // control
            // 
            this.control.Caption = "控制源";
            this.control.Name = "control";
            this.control.OptionsColumn.AllowEdit = false;
            this.control.OptionsColumn.ReadOnly = true;
            this.control.Visible = true;
            this.control.VisibleIndex = 4;
            // 
            // addr1
            // 
            this.addr1.Caption = "控制地址1";
            this.addr1.Name = "addr1";
            this.addr1.OptionsColumn.AllowEdit = false;
            this.addr1.OptionsColumn.ReadOnly = true;
            this.addr1.Visible = true;
            this.addr1.VisibleIndex = 5;
            // 
            // addr2
            // 
            this.addr2.Caption = "控制地址2";
            this.addr2.Name = "addr2";
            this.addr2.OptionsColumn.AllowEdit = false;
            this.addr2.OptionsColumn.ReadOnly = true;
            this.addr2.Visible = true;
            this.addr2.VisibleIndex = 6;
            // 
            // operate
            // 
            this.operate.Caption = "操作";
            this.operate.ColumnEdit = this.btn_edit;
            this.operate.Name = "operate";
            this.operate.Visible = true;
            this.operate.VisibleIndex = 7;
            // 
            // btn_edit
            // 
            this.btn_edit.AutoHeight = false;
            this.btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_edit_ButtonClick);
            // 
            // operate1
            // 
            this.operate1.Caption = "操作";
            this.operate1.ColumnEdit = this.btn_delete1;
            this.operate1.Name = "operate1";
            this.operate1.Visible = true;
            this.operate1.VisibleIndex = 8;
            // 
            // btn_delete1
            // 
            this.btn_delete1.AutoHeight = false;
            this.btn_delete1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true)});
            this.btn_delete1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_delete1.Name = "btn_delete1";
            this.btn_delete1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_delete1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_delete1_ButtonClick);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoHeight = false;
            this.btn_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", null, null, true)});
            this.btn_delete.Name = "btn_delete";
            // 
            // sbtn_insert
            // 
            this.sbtn_insert.Location = new System.Drawing.Point(964, 13);
            this.sbtn_insert.Name = "sbtn_insert";
            this.sbtn_insert.Size = new System.Drawing.Size(75, 31);
            this.sbtn_insert.TabIndex = 1;
            this.sbtn_insert.Text = "增加";
            this.sbtn_insert.Click += new System.EventHandler(this.sbtn_insert_Click);
            // 
            // sbtn_import
            // 
            this.sbtn_import.Location = new System.Drawing.Point(1068, 13);
            this.sbtn_import.Name = "sbtn_import";
            this.sbtn_import.Size = new System.Drawing.Size(75, 31);
            this.sbtn_import.TabIndex = 2;
            this.sbtn_import.Text = "导入";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(103, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 31);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "监控参数";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(298, 13);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 31);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "日志配置";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1156, 680);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sbtn_import);
            this.Controls.Add(this.sbtn_insert);
            this.Controls.Add(this.gcontrol_t_ios);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.Text = "IO信息表展示";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gcontrol_t_ios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcontrol_t_ios;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_edit;
        private DevExpress.XtraEditors.SimpleButton sbtn_insert;
        private DevExpress.XtraEditors.SimpleButton sbtn_import;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_delete1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ioname;
        private DevExpress.XtraGrid.Columns.GridColumn truetext;
        private DevExpress.XtraGrid.Columns.GridColumn falsetext;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn iotype;
        private DevExpress.XtraGrid.Columns.GridColumn control;
        private DevExpress.XtraGrid.Columns.GridColumn addr1;
        private DevExpress.XtraGrid.Columns.GridColumn addr2;
        private DevExpress.XtraGrid.Columns.GridColumn operate;
        private DevExpress.XtraGrid.Columns.GridColumn operate1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}

