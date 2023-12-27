using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOControl
{
    public partial class LogConfig : Form
    {

        public object queryById = null;

        //表单高度
        private float FormHeight;
        //表单宽度
        private float FormWidth;

        /// <summary>
        /// 数据库路径
        /// </summary>
        public string connectionString = "Data Source=" + "D:\\test.db;Version=3;";

        private AdaptFont adaptFont = new AdaptFont();
        public LogConfig()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LogInsertOrEditData logInsertOrEditData ;
            //IOInformationEntity ioInfo = new IOInformationEntity();
            //object id = null;
            int handle = gridView1.FocusedRowHandle;
            DataRow list = gridView1.GetDataRow(handle);
            if (gridView1 != null)
            {

                if (list != null)
                {
                    queryById = list["id"];
                    logInsertOrEditData = new LogInsertOrEditData(queryById);
                    logInsertOrEditData.Owner = this;
                    logInsertOrEditData.Text = "日志配置信息编辑";
                    logInsertOrEditData.txt_loname.Text = Convert.ToString(list["logname"]);
                    logInsertOrEditData.txt_logkey.Text = Convert.ToString(list["logkey"]);
                    logInsertOrEditData.txt_strtemplate.Text = Convert.ToString(list["strtemplate"]);
                    logInsertOrEditData.sbtn_insert.Text = "修改";
                    logInsertOrEditData.label1.Text = "日志配置修改信息功能";
                    logInsertOrEditData.insertOrQueryFlag = false;
                    logInsertOrEditData.ShowDialog();
                }

            }


        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deletelog_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //string connectionString = "Data Source=" + "D:\\test.db;Version=3;";
            DeleteLogData(connectionString, "t_logconfigure");
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtn_insert_Click(object sender, EventArgs e)
        {
            LogInsertOrEditData logInsertOrEditData = new LogInsertOrEditData();
            logInsertOrEditData.Owner = this;
            logInsertOrEditData.insertOrQueryFlag = true;
            logInsertOrEditData.ShowDialog();
        }

        private void LogConfig_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            gcontrol_t_logconfigure.DataSource = form1.QueryInfomation(connectionString, "t_logconfigure");
            id.FieldName = "id";
            logname.FieldName = "logname";
            logkey.FieldName = "logkey";
            strtemplate.FieldName = "strtemplate";



            //自适应大小
            FormWidth = this.Width;
            FormHeight = this.Height;
            adaptFont.setTag(this);
        }


        /// <summary>
        /// 删除日志配置数据方法
        /// </summary>
        /// <param name="filePath"></param>
        public void DeleteLogData(string filePath, string tableName)
        {
            Form1 form1 = new Form1();
            MessageBoxButtons messBtn = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确认要删除吗？", "删除成功！", messBtn);
            if (dr == DialogResult.OK)
            {
                if (gridView1 != null)
                {
                    int handle = gridView1.FocusedRowHandle;
                    DataRow list = gridView1.GetDataRow(handle);
                    if (list != null)
                    {
                        object id = list["id"];
                        form1.DeleteData(filePath, Convert.ToString(id), tableName);
                    }

                }
                MessageBox.Show("删除成功！");
            }
            RefreshForm();
            //gridView1.DeleteSelectedRows();
            //gridView1.RefreshData();


            //MessageBox.Show("确认要删除吗？");
        }


        /// <summary>
        /// 刷新主窗体中数据
        /// </summary>
        public void RefreshForm()
        {
            Form1 form1 = new Form1();
            string connectionString = "Data Source=" + "D:\\test.db;Version=3;";
            gcontrol_t_logconfigure.DataSource = form1.QueryInfomation(connectionString, "t_logconfigure");
        }

        private void LogConfig_Resize(object sender, EventArgs e)
        {
            adaptFont.Resize(this.Width, this.Height, FormWidth, FormHeight, this);
        }
    }
}
