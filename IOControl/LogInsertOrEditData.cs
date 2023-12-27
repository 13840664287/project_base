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
    public partial class LogInsertOrEditData : Form
    {
        /// <summary>
        /// 存储点击编辑时的获取的ID
        /// </summary>
        public string curr_id;

        //表单高度
        private float FormHeight;
        //表单宽度
        private float FormWidth;

        public bool insertOrQueryFlag = false;

        private AdaptFont adaptFont = new AdaptFont();
        public LogInsertOrEditData()
        {
            InitializeComponent();
        }

        public LogInsertOrEditData(object id)
        {
            InitializeComponent();
            curr_id = id.ToString();
        }

        /// <summary>
        /// 添加/编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtn_insert_Click(object sender, EventArgs e)
        {
            // 获取父窗体（Form_users）
            LogConfig formUsers = this.Owner as LogConfig;
            LogConfig logConfig = new LogConfig();
            if (insertOrQueryFlag)//insertOrQueryFlag为true是添加
            {
                
                //}
                string filePath = "Data Source=" + "D:\\test.db;Version=3;";
                string sql = "insert into " + "t_logconfigure" + " (logname,logkey,strtemplate) values(@value1,@value2,@value3)";
                using (SQLiteConnection connection = new SQLiteConnection(filePath))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        if (txt_logkey.Text == "")
                        {
                            MessageBox.Show("key名不能为空！");

                        }else if (txt_strtemplate.Text == "")
                        {
                            MessageBox.Show("日志模板不能为空！");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@value1", txt_loname.Text);
                            command.Parameters.AddWithValue("@value2", txt_logkey.Text);
                            command.Parameters.AddWithValue("@value3", txt_strtemplate.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("添加数据成功！");
                            logConfig.RefreshForm();
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
            else
            {
                string filePath = "Data Source=" + "D:\\test.db;Version=3;";
                string sql = "update  " + "t_logconfigure" + " set logname=@logName,logkey=@logkey,strtemplate=@strtemplate where id=" + curr_id;
                using (SQLiteConnection connection = new SQLiteConnection(filePath))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        if (txt_logkey.Text == "")
                        {
                            MessageBox.Show("key名不能为空！");

                        }
                        else if (txt_strtemplate.Text == "")
                        {
                            MessageBox.Show("日志模板不能为空！");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@logName", txt_loname.Text);
                            command.Parameters.AddWithValue("@logkey", txt_logkey.Text);
                            command.Parameters.AddWithValue("@strtemplate", txt_strtemplate.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("修改数据成功！");
                            logConfig.RefreshForm();
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
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInsertOrEditData_Load(object sender, EventArgs e)
        {
            //自适应大小
            FormWidth = this.Width;
            FormHeight = this.Height;
            adaptFont.setTag(this);
        }

        private void LogInsertOrEditData_Resize(object sender, EventArgs e)
        {
            adaptFont.Resize(this.Width, this.Height, FormWidth, FormHeight, this);
        }
    }
}
