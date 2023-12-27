using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOControl
{
    public partial class MonitorParaInsertOrEditData : Form
    {
        /// <summary>
        /// 判断增加还是编辑的标志位
        /// </summary>
        public bool insertOrQueryFlag = false;

        /// <summary>
        /// 存储点击编辑时的获取的ID
        /// </summary>
        public string curr_id;

        /// <summary>
        /// 正则表达式约束int
        /// </summary>
        public string patternInt = @"^[0-9]*$";

        //表单高度
        private float FormHeight;
        //表单宽度
        private float FormWidth;

        private AdaptFont adaptFont = new AdaptFont();

        public MonitorParaInsertOrEditData()
        {
            InitializeComponent();
        }

        public MonitorParaInsertOrEditData(object id)
        {
            InitializeComponent();
            curr_id = id.ToString();
        }


        private void MonitorParaInsertOrEditData_Resize(object sender, EventArgs e)
        {
            adaptFont.Resize(this.Width, this.Height, FormWidth, FormHeight, this);
        }

        private void MonitorParaInsertOrEditData_Load(object sender, EventArgs e)
        {
            //自适应大小
            FormWidth = this.Width;
            FormHeight = this.Height;
            adaptFont.setTag(this);
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
        /// <summary>
        /// 添加/编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtn_insert_Click(object sender, EventArgs e)
        {
            // 获取父窗体（Form_users）
            MonitorPara formUsers = this.Owner as MonitorPara;
            LogConfig logConfig = new LogConfig();
            if (insertOrQueryFlag)//insertOrQueryFlag为true是添加
            {
                string filePath = "Data Source=" + "D:\\test.db;Version=3;";
                string sql = "insert into " + "t_keyparameters" + " (ioname,upthreshv,upenableflg,upcolor,dwnthreshv,dwnenableflg,dwncolor,datatype,startaddr) values(@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9)";
                using (SQLiteConnection connection = new SQLiteConnection(filePath))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        float result;
                        if (txt_ioname.Text == "")
                        {
                            MessageBox.Show("名称不能为空！");

                        }
                        else if (!float.TryParse(txt_upthreshv.Text, out result) && !(txt_upthreshv.Text == ""))
                        {
                            
                            MessageBox.Show("请在上阈值中输入整型数字或小数！");
                        }
                        else if (!Regex.IsMatch(txt_upcolor.Text, patternInt) && !(txt_upcolor.Text == ""))
                        {
                            MessageBox.Show("请在上颜色中输入整型数字！");
                        }
                        else if (!float.TryParse(txt_dwnthreshv.Text, out result) && !(txt_dwnthreshv.Text == ""))
                        {
                            MessageBox.Show("请在下阈值输入整型数字或小数！");
                        }
                        else if (!Regex.IsMatch(txt_dwnenableflg.Text, patternInt) && !(txt_dwnenableflg.Text == ""))
                        {
                            MessageBox.Show("请在下启用标志中输入整型数字！");
                        }
                        else if (!Regex.IsMatch(txt_dwncolor.Text, patternInt) && !(txt_dwncolor.Text == ""))
                        {
                            MessageBox.Show("请在下颜色中输入整型数字！");
                        } 
                        
                        else
                        {
                            command.Parameters.AddWithValue("@value1", txt_ioname.Text);
                            command.Parameters.AddWithValue("@value2", txt_upthreshv.Text);
                            command.Parameters.AddWithValue("@value3", cmbox_upenableflg.Text);
                            command.Parameters.AddWithValue("@value4", txt_upcolor.Text);
                            command.Parameters.AddWithValue("@value5", txt_dwnthreshv.Text);
                            command.Parameters.AddWithValue("@value6", txt_dwnenableflg.Text);
                            command.Parameters.AddWithValue("@value7", txt_dwncolor.Text);
                            command.Parameters.AddWithValue("@value8", txt_datatype.Text);
                            command.Parameters.AddWithValue("@value9", txt_startaddr.Text);
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
                string sql = "update  " + "t_keyparameters" + " set ioname=@ioName,upthreshv=@upThreshv,upenableflg=@upEnableFlg,upcolor=@upColor,dwnthreshv=@dwnThreshv,dwnenableflg=@dwnEnableFlg,dwncolor=@dwnColor,datatype=@dataType,startaddr=@startAddr where id=" + curr_id;
                using (SQLiteConnection connection = new SQLiteConnection(filePath))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        float result;
                        if (txt_ioname.Text == "")
                        {
                            MessageBox.Show("名称不能为空！");

                        }
                        else if (!float.TryParse(txt_upthreshv.Text, out result) && !(txt_upthreshv.Text == ""))
                        {

                            MessageBox.Show("请在上阈值中输入整型数字或小数！");
                        }
                        else if (!Regex.IsMatch(txt_upcolor.Text, patternInt) && !(txt_upcolor.Text == ""))
                        {
                            MessageBox.Show("请在上颜色中输入整型数字！");
                        }
                        else if (!float.TryParse(txt_dwnthreshv.Text, out result) && !(txt_dwnthreshv.Text == ""))
                        {
                            MessageBox.Show("请在下阈值输入整型数字或小数！");
                        }
                        else if (!Regex.IsMatch(txt_dwnenableflg.Text, patternInt) && !(txt_dwnenableflg.Text == ""))
                        {
                            MessageBox.Show("请在下启用标志中输入整型数字！");
                        }
                        else if (!Regex.IsMatch(txt_dwncolor.Text, patternInt) && !(txt_dwncolor.Text == ""))
                        {
                            MessageBox.Show("请在下颜色中输入整型数字！");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ioName", txt_ioname.Text);
                            command.Parameters.AddWithValue("@upThreshv", txt_upthreshv.Text);
                            command.Parameters.AddWithValue("@upEnableFlg", cmbox_upenableflg.Text);
                            command.Parameters.AddWithValue("@upColor", txt_upcolor.Text);
                            command.Parameters.AddWithValue("@dwnThreshv", txt_dwnthreshv.Text);
                            command.Parameters.AddWithValue("@dwnEnableFlg", txt_dwnenableflg.Text);
                            command.Parameters.AddWithValue("@dwnColor", txt_dwncolor.Text);
                            command.Parameters.AddWithValue("@dataType", txt_datatype.Text);
                            command.Parameters.AddWithValue("@startAddr", txt_startaddr.Text);
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


    }
}
