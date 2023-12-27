namespace LogConfig
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.logname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.logkey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.strtemplate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sbtn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_import = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_edit});
            this.gridControl1.Size = new System.Drawing.Size(1538, 621);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.logname,
            this.logkey,
            this.strtemplate,
            this.edit});
            this.gridView1.GridControl = this.gridControl1;
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
            // logname
            // 
            this.logname.Caption = "名称";
            this.logname.Name = "logname";
            this.logname.Visible = true;
            this.logname.VisibleIndex = 1;
            // 
            // logkey
            // 
            this.logkey.Caption = "key";
            this.logkey.Name = "logkey";
            this.logkey.Visible = true;
            this.logkey.VisibleIndex = 2;
            // 
            // strtemplate
            // 
            this.strtemplate.Caption = "日志模板";
            this.strtemplate.Name = "strtemplate";
            this.strtemplate.Visible = true;
            this.strtemplate.VisibleIndex = 3;
            // 
            // edit
            // 
            this.edit.Caption = "操作";
            this.edit.ColumnEdit = this.btn_edit;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 4;
            // 
            // btn_edit
            // 
            this.btn_edit.AutoHeight = false;
            this.btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // sbtn_insert
            // 
            this.sbtn_insert.Location = new System.Drawing.Point(1303, 13);
            this.sbtn_insert.Name = "sbtn_insert";
            this.sbtn_insert.Size = new System.Drawing.Size(75, 31);
            this.sbtn_insert.TabIndex = 3;
            this.sbtn_insert.Text = "增加";
            // 
            // sbtn_import
            // 
            this.sbtn_import.Location = new System.Drawing.Point(1445, 13);
            this.sbtn_import.Name = "sbtn_import";
            this.sbtn_import.Size = new System.Drawing.Size(75, 31);
            this.sbtn_import.TabIndex = 4;
            this.sbtn_import.Text = "导入";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 671);
            this.Controls.Add(this.sbtn_import);
            this.Controls.Add(this.sbtn_insert);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn logname;
        private DevExpress.XtraGrid.Columns.GridColumn logkey;
        private DevExpress.XtraGrid.Columns.GridColumn strtemplate;
        private DevExpress.XtraGrid.Columns.GridColumn edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_edit;
        private DevExpress.XtraEditors.SimpleButton sbtn_insert;
        private DevExpress.XtraEditors.SimpleButton sbtn_import;
    }
}

