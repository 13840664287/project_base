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
    public partial class IOInsertData : Form
    {
        public string curr_id;
        //表单高度
        private float FormHeight;
        //表单宽度
        private float FormWidth;

        private AdaptFont adaptFont = new AdaptFont();
        /// <summary>
        /// 添加修改标记位
        /// </summary>
        public bool insertOrQueryFlag = false;
        Form1 form1 = new Form1();
        public IOInsertData()
        {
            InitializeComponent();      
        }
        
        public IOInsertData(object id)
        {
            InitializeComponent();
            curr_id = id.ToString();
        }



        private void IOInsertData_Load(object sender, EventArgs e)
        {
            //自适应大小
            FormWidth = this.Width;
            FormHeight = this.Height;
            adaptFont.setTag(this);
        }

        private void IOInsertData_Resize(object sender, EventArgs e)
        {
            adaptFont.Resize(this.Width, this.Height, FormWidth, FormHeight, this);
        }

        private void sbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtn_insert_Click(object sender, EventArgs e)
        {
            // 获取父窗体（Form_users）
            Form1 formUsers = this.Owner as Form1;
            if (insertOrQueryFlag)//insertOrQueryFlag为true是添加
            {
                //IOInformationEntity ioInfo = new IOInformationEntity();
                ////DataRow aaa = new DataRow();
                ////DataRow aaa = new DataRow();
                //if (txt_ioname.Text == "")
                //{
                //    MessageBox.Show("名称不能为空！");
                //}
                //else
                //{
                //    string filePath = "Data Source=" + "D:\\test.db;Version=3;";
                //    ioInfo.IoName = txt_ioname.Text;
                //    ioInfo.TrueText = txt_truetext.Text;
                //    ioInfo.FalseText = txt_falsetext.Text;
                //    if(cmbox_iotype.Text == "")
                //    {
                //        int? x;
                //        x = null;
                //        ioInfo.IoType = Convert.ToInt32(x);
                //    }else if(cmbox_control.Text == "")
                //    {
                //        int? y;
                //        y = null;
                //        ioInfo.IoType = Convert.ToInt32(y);
                //    }
                //    //ioInfo.IoType = Convert.ToInt32(cmbox_iotype.Text);
                //    ioInfo.Control = Convert.ToInt32(cmbox_control.Text);
                //    ioInfo.Addr1 = txt_addr1.Text;
                //    ioInfo.Addr2 = txt_addr2.Text;
                //    form1.InsertData(filePath, "t_ios", ioInfo);
                //    this.Close();


                //    MessageBox.Show("添加数据成功！");
                //}
                
                string filePath = "Data Source=" + "D:\\test.db;Version=3;";
                string sql = "insert into " + "t_ios" + " (ioname,truetext,falsetext,iotype,control,addr1,addr2) values(@value1,@value2,@value3,@value4,@value5,@value6,@value7)";
                using (SQLiteConnection connection = new SQLiteConnection(filePath))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        if (txt_ioname.Text == "")
                        {
                            MessageBox.Show("名称不能为空！");

                        }
                        else
                        {
                            command.Parameters.AddWithValue("@value1", txt_ioname.Text);
                            command.Parameters.AddWithValue("@value2", txt_truetext.Text);
                            command.Parameters.AddWithValue("@value3", txt_falsetext.Text);
                            command.Parameters.AddWithValue("@value4", cmbox_iotype.Text);
                            command.Parameters.AddWithValue("@value5", cmbox_control.Text);
                            command.Parameters.AddWithValue("@value6", txt_addr1.Text);
                            command.Parameters.AddWithValue("@value7", txt_addr2.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("添加数据成功！");
                            this.Close();
                            // 确保获取到父窗体后，调用刷新数据的方法
                            if (formUsers != null)
                            {
                                formUsers.RefreshForm();
                            }
                        }
                    }
                }
                

            }
            else//修改
            {
                string filePath = "Data Source=" + "D:\\test.db;Version=3;";
                string sql = "update  " + "t_ios" + " set ioname=@ioName,truetext=@trueText,falsetext=@falseText,iotype=@ioType,control=@Control,addr1=@Addr1,addr2=@Addr2 where id=" + curr_id;
                using (SQLiteConnection connection = new SQLiteConnection(filePath))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        if (txt_ioname.Text == "")
                        {
                            MessageBox.Show("名称不能为空！");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ioName", txt_ioname.Text);
                            command.Parameters.AddWithValue("@trueText", txt_truetext.Text);
                            command.Parameters.AddWithValue("@falseText", txt_falsetext.Text);
                            command.Parameters.AddWithValue("@ioType", cmbox_iotype.Text);
                            command.Parameters.AddWithValue("@Control", cmbox_control.Text);
                            command.Parameters.AddWithValue("@Addr1", txt_addr1.Text);
                            command.Parameters.AddWithValue("@Addr2", txt_addr2.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("修改数据成功！");
                            this.Close();
                            // 确保获取到父窗体后，调用刷新数据的方法
                            if (formUsers != null)
                            {
                                formUsers.RefreshForm();
                            }
                        }

                    }
                }
            }
            //form1.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="tableName"></param>
        /// <param name="ioInfo"></param>
        public void UpdateData(string filePath, string tableName, string id, IOInformationEntity ioInfo)
        {
            string sql = "update  " + tableName + " set ioname=@ioName,truetext=@trueText,falsetext=@falseText,iotype=@ioType,control=@Control,addr1=@Addr1,addr2=@Addr2,where id=" + id;
            using (SQLiteConnection connection = new SQLiteConnection(filePath))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ioName", ioInfo.IoName);
                    command.Parameters.AddWithValue("@trueText", ioInfo.TrueText);
                    command.Parameters.AddWithValue("@falseText", ioInfo.FalseText);
                    command.Parameters.AddWithValue("@ioType", ioInfo.IoType);
                    command.Parameters.AddWithValue("@Control", ioInfo.Control);
                    command.Parameters.AddWithValue("@Addr1", ioInfo.Addr1);
                    command.Parameters.AddWithValue("@Addr2", ioInfo.Addr2);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void IOInsertData_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.RefreshForm();
        }
    }
}
