using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOControl
{
    public partial class Form1 : Form
    {
        //表单高度
        private float FormHeight;
        //表单宽度
        private float FormWidth;

        private AdaptFont adaptFont = new AdaptFont();
        /// <summary>
        /// 接受编辑时查询的ID
        /// </summary>
        public object queryById = null;

        



        public string connectionString = "Data Source=" + "D:\\test.db;Version=3;";
        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            gcontrol_t_ios.DataSource = QueryInfomation(connectionString, "t_ios");
            id.FieldName = "id";
            ioname.FieldName = "ioname";
            truetext.FieldName = "truetext";
            falsetext.FieldName = "falsetext";
            iotype.FieldName = "iotype";
            control.FieldName = "control";
            addr1.FieldName = "addr1";
            addr2.FieldName = "addr2";

            //自适应大小
            FormWidth = this.Width;
            FormHeight = this.Height;
            adaptFont.setTag(this);
        }

        /// <summary>
        /// 编辑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            IOInsertData ioInsertData;
            //IOInformationEntity ioInfo = new IOInformationEntity();
            //object id = null;
            int handle = gridView1.FocusedRowHandle;
            DataRow list = gridView1.GetDataRow(handle);
            if (gridView1 != null)
            {
                
                if (list != null)
                {
                    queryById = list["id"];
                    ioInsertData = new IOInsertData(queryById);
                    ioInsertData.Owner = this;
                    ioInsertData.Text = "IO信息编辑";
                    ioInsertData.txt_ioname.Text = Convert.ToString(list["ioname"]);
                    ioInsertData.txt_truetext.Text = Convert.ToString(list["truetext"]);
                    ioInsertData.txt_falsetext.Text = Convert.ToString(list["falsetext"]);
                    ioInsertData.cmbox_iotype.Text = Convert.ToString(list["iotype"]);
                    ioInsertData.cmbox_control.Text = Convert.ToString(list["control"]);
                    ioInsertData.txt_addr1.Text = Convert.ToString(list["addr1"]);
                    ioInsertData.txt_addr2.Text = Convert.ToString(list["addr2"]);
                    ioInsertData.sbtn_insert.Text = "修改";
                    ioInsertData.label1.Text = "I/O修改信息功能";
                    ioInsertData.insertOrQueryFlag = false;
                    ioInsertData.ShowDialog();
                }

            }
            //ioInfo = QueryById(connectionString, "t_ios", Convert.ToString(id));

            //ioInsertData.Text = "IO信息编辑";
            //ioInsertData.txt_ioname.Text = Convert.ToString(list["ioname"]);
            //ioInsertData.txt_truetext.Text = Convert.ToString(list["truetext"]);
            //ioInsertData.txt_falsetext.Text = Convert.ToString(list["falsetext"]);
            //ioInsertData.cmbox_iotype.Text = Convert.ToString(list["iotype"]);
            //ioInsertData.cmbox_control.Text = Convert.ToString(list["control"]);
            //ioInsertData.txt_addr1.Text = Convert.ToString(list["addr1"]);
            //ioInsertData.txt_addr2.Text = Convert.ToString(list["addr2"]);
            //ioInsertData.sbtn_insert.Text = "修改";
            //ioInsertData.label1.Text = "I/O修改信息功能";
            //ioInsertData.insertOrQueryFlag = false;
            //ioInsertData.ShowDialog();
        }
        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //string connectionString = "Data Source=" + "D:\\test.db;Version=3;";
            DeleteIOData(connectionString, "t_ios");
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtn_insert_Click(object sender, EventArgs e)
        {
            IOInsertData ioInsertData = new IOInsertData();
            ioInsertData.Owner = this;
            ioInsertData.insertOrQueryFlag = true;
            ioInsertData.ShowDialog();
        }
        /// <summary>
        /// 查询到数据在主页面中显示
        /// </summary>
        /// <param name="filepath">数据库文件路径</param>
        /// <returns></returns>
        public DataTable QueryInfomation(string filepath, string tableName)
        {
            DataTable dataTable = new DataTable();
            //List<IOInformationEntity> list = new List<IOInformationEntity>();
            
            using (SQLiteConnection connection = new SQLiteConnection(filepath))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM " + tableName, connection))
                {
                    //SQLiteDataAdapter类可以将数据填充到DataTable里
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill (dataTable);
                    }
                }

                connection.Close();
            }
            return dataTable;
        }
        /// <summary>
        /// 删除IO数据方法
        /// </summary>
        /// <param name="filePath"></param>
        public void DeleteIOData(string filePath, string tableName)
        {
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
                        DeleteData(filePath, Convert.ToString(id), tableName);
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
        /// 公共删除方法
        /// </summary>
        /// <param name="filePath">数据库文件</param>
        /// <param name="deleteId">删除id</param>
        /// <param name="tableName">数据库表名</param>
        public void DeleteData(string filePath, string deleteId, string tableName)
        {
            string sql = "delete from " + tableName + " where id=" + deleteId;
            using (SQLiteConnection connection = new SQLiteConnection(filePath))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand( sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        /// <summary>
        /// IO添加方法
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="tableName"></param>
        /// <param name="ioInfo"></param>+*/
        public void InsertData(string filePath, string tableName, IOInformationEntity ioInfo)
        {
            string sql = "insert into " + tableName + " (ioname,truetext,falsetext,iotype,control,addr1,addr2) values(@value1,@value2,@value3,@value4,@value5,@value6,@value7)";
            using (SQLiteConnection connection = new SQLiteConnection(filePath))
            {
                connection.Open();
                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@value1", ioInfo.IoName);
                    command.Parameters.AddWithValue("@value2", ioInfo.TrueText);
                    command.Parameters.AddWithValue("@value3", ioInfo.FalseText);
                    command.Parameters.AddWithValue("@value4", ioInfo.IoType);
                    command.Parameters.AddWithValue("@value5", ioInfo.Control);
                    command.Parameters.AddWithValue("@value6", ioInfo.Addr1);
                    command.Parameters.AddWithValue("@value7", ioInfo.Addr2);
                    command.ExecuteNonQuery();
                }
            }
        }

        
        private void Form1_Resize(object sender, EventArgs e)
        {
            adaptFont.Resize(this.Width, this.Height, FormWidth, FormHeight, this);
        }

        /// <summary>
        /// 根据Id查询IO数据
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public IOInformationEntity QueryById(string filePath, string tableName, string id)
        {
            IOInformationEntity ioInfo = null;
            string sql = "select * from " + tableName + " where id=" + id;
            using (SQLiteConnection connection = new SQLiteConnection(filePath))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ioInfo = new IOInformationEntity
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IoName = Convert.ToString(reader["ioname"]),
                                TrueText = Convert.ToString(reader["truetext"]),
                                FalseText = Convert.ToString(reader["falsetext"]),
                                IoType = Convert.ToInt32(reader["iotype"]),
                                Control = Convert.ToInt32(reader["control"]),
                                Addr1 = Convert.ToString(reader["addr1"]),
                                Addr2 = Convert.ToString(reader["addr2"]),
                            };
                        }
                    }
                }

                connection.Close();
            }
            return ioInfo;
        }

        /// <summary>
        /// 刷新主窗体中数据
        /// </summary>
        public void RefreshForm()
        {
            string connectionString = "Data Source=" + "D:\\test.db;Version=3;";
            gcontrol_t_ios.DataSource = QueryInfomation(connectionString, "t_ios");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MonitorPara m = new MonitorPara();
            m.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LogConfig l = new LogConfig();
            l.ShowDialog();
        }
    }
}
