namespace MonitorPara
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.sbtn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_import = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcontrol_t_keyparameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // gcontrol_t_keyparameters
            // 
            this.gcontrol_t_keyparameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcontrol_t_keyparameters.Location = new System.Drawing.Point(0, 50);
            this.gcontrol_t_keyparameters.MainView = this.gridView1;
            this.gcontrol_t_keyparameters.Name = "gcontrol_t_keyparameters";
            this.gcontrol_t_keyparameters.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_edit});
            this.gcontrol_t_keyparameters.Size = new System.Drawing.Size(1279, 585);
            this.gcontrol_t_keyparameters.TabIndex = 0;
            this.gcontrol_t_keyparameters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
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
            this.edit});
            this.gridView1.GridControl = this.gcontrol_t_keyparameters;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            // 
            // ioname
            // 
            this.ioname.Caption = "名称";
            this.ioname.Name = "ioname";
            this.ioname.Visible = true;
            this.ioname.VisibleIndex = 1;
            // 
            // upthreshv
            // 
            this.upthreshv.Caption = "上阈值";
            this.upthreshv.Name = "upthreshv";
            this.upthreshv.Visible = true;
            this.upthreshv.VisibleIndex = 2;
            // 
            // upenableflg
            // 
            this.upenableflg.Caption = "上启用标志";
            this.upenableflg.Name = "upenableflg";
            this.upenableflg.Visible = true;
            this.upenableflg.VisibleIndex = 3;
            // 
            // upcolor
            // 
            this.upcolor.Caption = "上颜色";
            this.upcolor.Name = "upcolor";
            this.upcolor.Visible = true;
            this.upcolor.VisibleIndex = 4;
            // 
            // dwnthreshv
            // 
            this.dwnthreshv.Caption = "下阈值";
            this.dwnthreshv.Name = "dwnthreshv";
            this.dwnthreshv.Visible = true;
            this.dwnthreshv.VisibleIndex = 5;
            // 
            // dwnenableflg
            // 
            this.dwnenableflg.Caption = "下启用标志";
            this.dwnenableflg.Name = "dwnenableflg";
            this.dwnenableflg.Visible = true;
            this.dwnenableflg.VisibleIndex = 6;
            // 
            // dwncolor
            // 
            this.dwncolor.Caption = "下颜色";
            this.dwncolor.Name = "dwncolor";
            this.dwncolor.Visible = true;
            this.dwncolor.VisibleIndex = 7;
            // 
            // datatype
            // 
            this.datatype.Caption = "阈值类型";
            this.datatype.Name = "datatype";
            this.datatype.Visible = true;
            this.datatype.VisibleIndex = 8;
            // 
            // startaddr
            // 
            this.startaddr.Caption = "起始地址";
            this.startaddr.Name = "startaddr";
            this.startaddr.Visible = true;
            this.startaddr.VisibleIndex = 9;
            // 
            // edit
            // 
            this.edit.Caption = "操作";
            this.edit.ColumnEdit = this.btn_edit;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 10;
            // 
            // btn_edit
            // 
            this.btn_edit.AutoHeight = false;
            this.btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // sbtn_insert
            // 
            this.sbtn_insert.Location = new System.Drawing.Point(1082, 13);
            this.sbtn_insert.Name = "sbtn_insert";
            this.sbtn_insert.Size = new System.Drawing.Size(75, 31);
            this.sbtn_insert.TabIndex = 2;
            this.sbtn_insert.Text = "增加";
            // 
            // sbtn_import
            // 
            this.sbtn_import.Location = new System.Drawing.Point(1187, 13);
            this.sbtn_import.Name = "sbtn_import";
            this.sbtn_import.Size = new System.Drawing.Size(75, 31);
            this.sbtn_import.TabIndex = 3;
            this.sbtn_import.Text = "导入";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 635);
            this.Controls.Add(this.sbtn_import);
            this.Controls.Add(this.sbtn_insert);
            this.Controls.Add(this.gcontrol_t_keyparameters);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcontrol_t_keyparameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton sbtn_insert;
        private DevExpress.XtraEditors.SimpleButton sbtn_import;
    }
}

