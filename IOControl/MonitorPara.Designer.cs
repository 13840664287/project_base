namespace IOControl
{
    partial class MonitorPara
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorPara));
            this.gcontrol_t_keyparameters = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ioname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.upthreshv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.upenableflg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.upcolor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dwnthreshv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dwnenableflg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dwncolor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datatype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.startaddr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sbtn_import = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_insert = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcontrol_t_keyparameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // gcontrol_t_keyparameters
            // 
            this.gcontrol_t_keyparameters.Location = new System.Drawing.Point(-2, 53);
            this.gcontrol_t_keyparameters.MainView = this.gridView1;
            this.gcontrol_t_keyparameters.Name = "gcontrol_t_keyparameters";
            this.gcontrol_t_keyparameters.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_edit,
            this.btn_delete});
            this.gcontrol_t_keyparameters.Size = new System.Drawing.Size(1291, 474);
            this.gcontrol_t_keyparameters.TabIndex = 1;
            this.gcontrol_t_keyparameters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.ioname,
            this.upthreshv,
            this.upenableflg,
            this.upcolor,
            this.dwnthreshv,
            this.dwnenableflg,
            this.dwncolor,
            this.datatype,
            this.startaddr,
            this.edit,
            this.delete});
            this.gridView1.GridControl = this.gcontrol_t_keyparameters;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.Name = "id";
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
            // upthreshv
            // 
            this.upthreshv.Caption = "上阈值";
            this.upthreshv.Name = "upthreshv";
            this.upthreshv.OptionsColumn.AllowEdit = false;
            this.upthreshv.OptionsColumn.ReadOnly = true;
            this.upthreshv.Visible = true;
            this.upthreshv.VisibleIndex = 1;
            // 
            // upenableflg
            // 
            this.upenableflg.Caption = "上启用标志";
            this.upenableflg.Name = "upenableflg";
            this.upenableflg.OptionsColumn.AllowEdit = false;
            this.upenableflg.OptionsColumn.ReadOnly = true;
            this.upenableflg.Visible = true;
            this.upenableflg.VisibleIndex = 2;
            // 
            // upcolor
            // 
            this.upcolor.Caption = "上颜色";
            this.upcolor.Name = "upcolor";
            this.upcolor.OptionsColumn.AllowEdit = false;
            this.upcolor.OptionsColumn.ReadOnly = true;
            this.upcolor.Visible = true;
            this.upcolor.VisibleIndex = 3;
            // 
            // dwnthreshv
            // 
            this.dwnthreshv.Caption = "下阈值";
            this.dwnthreshv.Name = "dwnthreshv";
            this.dwnthreshv.OptionsColumn.AllowEdit = false;
            this.dwnthreshv.OptionsColumn.ReadOnly = true;
            this.dwnthreshv.Visible = true;
            this.dwnthreshv.VisibleIndex = 4;
            // 
            // dwnenableflg
            // 
            this.dwnenableflg.Caption = "下启用标志";
            this.dwnenableflg.Name = "dwnenableflg";
            this.dwnenableflg.OptionsColumn.AllowEdit = false;
            this.dwnenableflg.OptionsColumn.ReadOnly = true;
            this.dwnenableflg.Visible = true;
            this.dwnenableflg.VisibleIndex = 5;
            // 
            // dwncolor
            // 
            this.dwncolor.Caption = "下颜色";
            this.dwncolor.Name = "dwncolor";
            this.dwncolor.OptionsColumn.AllowEdit = false;
            this.dwncolor.OptionsColumn.ReadOnly = true;
            this.dwncolor.Visible = true;
            this.dwncolor.VisibleIndex = 6;
            // 
            // datatype
            // 
            this.datatype.Caption = "阈值类型";
            this.datatype.Name = "datatype";
            this.datatype.OptionsColumn.AllowEdit = false;
            this.datatype.OptionsColumn.ReadOnly = true;
            this.datatype.Visible = true;
            this.datatype.VisibleIndex = 7;
            // 
            // startaddr
            // 
            this.startaddr.Caption = "起始地址";
            this.startaddr.Name = "startaddr";
            this.startaddr.OptionsColumn.AllowEdit = false;
            this.startaddr.OptionsColumn.ReadOnly = true;
            this.startaddr.Visible = true;
            this.startaddr.VisibleIndex = 8;
            // 
            // edit
            // 
            this.edit.Caption = "操作";
            this.edit.ColumnEdit = this.btn_edit;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 9;
            // 
            // btn_edit
            // 
            this.btn_edit.AutoHeight = false;
            this.btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_edit_ButtonClick);
            // 
            // delete
            // 
            this.delete.Caption = "操作";
            this.delete.ColumnEdit = this.btn_delete;
            this.delete.Name = "delete";
            this.delete.Visible = true;
            this.delete.VisibleIndex = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoHeight = false;
            this.btn_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btn_delete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_delete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_delete_ButtonClick);
            // 
            // sbtn_import
            // 
            this.sbtn_import.Location = new System.Drawing.Point(1214, 16);
            this.sbtn_import.Name = "sbtn_import";
            this.sbtn_import.Size = new System.Drawing.Size(75, 31);
            this.sbtn_import.TabIndex = 5;
            this.sbtn_import.Text = "导入";
            // 
            // sbtn_insert
            // 
            this.sbtn_insert.Location = new System.Drawing.Point(1094, 16);
            this.sbtn_insert.Name = "sbtn_insert";
            this.sbtn_insert.Size = new System.Drawing.Size(75, 31);
            this.sbtn_insert.TabIndex = 4;
            this.sbtn_insert.Text = "增加";
            this.sbtn_insert.Click += new System.EventHandler(this.sbtn_insert_Click);
            // 
            // MonitorPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1289, 526);
            this.Controls.Add(this.sbtn_import);
            this.Controls.Add(this.sbtn_insert);
            this.Controls.Add(this.gcontrol_t_keyparameters);
            this.Name = "MonitorPara";
            this.Text = "MonitorPara";
            this.Load += new System.EventHandler(this.MonitorPara_Load);
            this.Resize += new System.EventHandler(this.MonitorPara_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gcontrol_t_keyparameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcontrol_t_keyparameters;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn ioname;
        private DevExpress.XtraGrid.Columns.GridColumn upthreshv;
        private DevExpress.XtraGrid.Columns.GridColumn upenableflg;
        private DevExpress.XtraGrid.Columns.GridColumn upcolor;
        private DevExpress.XtraGrid.Columns.GridColumn dwnthreshv;
        private DevExpress.XtraGrid.Columns.GridColumn dwnenableflg;
        private DevExpress.XtraGrid.Columns.GridColumn dwncolor;
        private DevExpress.XtraGrid.Columns.GridColumn datatype;
        private DevExpress.XtraGrid.Columns.GridColumn startaddr;
        private DevExpress.XtraGrid.Columns.GridColumn edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_edit;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_delete;
        private DevExpress.XtraEditors.SimpleButton sbtn_import;
        private DevExpress.XtraEditors.SimpleButton sbtn_insert;
    }
}