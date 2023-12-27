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
    public partial class MonitorPara : Form
    {

        //表单高度
        private float FormHeight;
        //表单宽度
        private float FormWidth;

        private AdaptFont adaptFont = new AdaptFont();

        public string connectionString = "Data Source=" + "D:\\test.db;Version=3;";

        public object queryById = null;

        public MonitorPara()
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
            MonitorParaInsertOrEditData monitorParaInsertOrEditData;

            int handle = gridView1.FocusedRowHandle;
            DataRow list = gridView1.GetDataRow(handle);
            if (gridView1 != null)
            {

                if (list != null)
                {
                    queryById = list["id"];
                    monitorParaInsertOrEditData = new MonitorParaInsertOrEditData(queryById);
                    monitorParaInsertOrEditData.Owner = this;
                    monitorParaInsertOrEditData.Text = "监控参数信息编辑";
                    monitorParaInsertOrEditData.txt_ioname.Text = Convert.ToString(list["ioname"]);
                    monitorParaInsertOrEditData.txt_upthreshv.Text = Convert.ToString(list["upthreshv"]);
                    monitorParaInsertOrEditData.cmbox_upenableflg.Text = Convert.ToString(list["upenableflg"]);
                    monitorParaInsertOrEditData.txt_upcolor.Text = Convert.ToString(list["upcolor"]);
                    monitorParaInsertOrEditData.txt_dwnthreshv.Text = Convert.ToString(list["dwnthreshv"]);
                    monitorParaInsertOrEditData.txt_dwnenableflg.Text = Convert.ToString(list["dwnenableflg"]);
                    monitorParaInsertOrEditData.txt_dwncolor.Text = Convert.ToString(list["dwncolor"]);
                    monitorParaInsertOrEditData.txt_datatype.Text = Convert.ToString(list["datatype"]);
                    monitorParaInsertOrEditData.txt_startaddr.Text = Convert.ToString(list["startaddr"]);
                    monitorParaInsertOrEditData.sbtn_insert.Text = "修改";
                    monitorParaInsertOrEditData.label1.Text = "监控参数修改信息功能";
                    monitorParaInsertOrEditData.insertOrQueryFlag = false;
                    monitorParaInsertOrEditData.ShowDialog();
                }

            }


            
        }
        private void MonitorPara_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            gcontrol_t_keyparameters.DataSource = form1.QueryInfomation(connectionString, "t_keyparameters");
            id.FieldName = "id";
            ioname.FieldName = "ioname";
            upthreshv.FieldName = "upthreshv";
            upenableflg.FieldName = "upenableflg";
            upcolor.FieldName = "upcolor";
            dwnthreshv.FieldName = "dwnthreshv";
            dwnenableflg.FieldName = "dwnenableflg";
            dwncolor.FieldName = "dwncolor";
            datatype.FieldName = "datatype";
            startaddr.FieldName = "startaddr";

            //自适应大小
            FormWidth = this.Width;
            FormHeight = this.Height;
            adaptFont.setTag(this);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DeleteLogData(connectionString, "t_keyparameters");
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtn_insert_Click(object sender, EventArgs e)
        {
            MonitorParaInsertOrEditData monitorParaInsertOrEditData = new MonitorParaInsertOrEditData();
            monitorParaInsertOrEditData.Owner = this;
            monitorParaInsertOrEditData.insertOrQueryFlag = true;
            monitorParaInsertOrEditData.ShowDialog();
        }

        

        private void MonitorPara_Resize(object sender, EventArgs e)
        {
            adaptFont.Resize(this.Width, this.Height, FormWidth, FormHeight, this);
        }


        /// <summary>
        /// 删除监控参数数据方法
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
            
        }

        /// <summary>
        /// 刷新主窗体中数据
        /// </summary>
        public void RefreshForm()
        {
            Form1 form1 = new Form1();
            gcontrol_t_keyparameters.DataSource = form1.QueryInfomation(connectionString, "t_keyparameters");
        }
    }
}
