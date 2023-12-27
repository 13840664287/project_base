using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOControl
{
    class AdaptFont
    {

        /// <summary>
        /// 重新加载界面
        /// </summary>
        /// <param name="cons"></param>
        public void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        /// <summary>
        /// 获取到拖拽后新界面的大小
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <param name="cons"></param>
        public void setControls(float newX, float newY, Control cons)
        {
            try
            {
                foreach (Control con in cons.Controls)
                {
                    string[] myTag = con.Tag.ToString().Split(new char[] { ':' });
                    float a = System.Convert.ToSingle(myTag[0]) * newX;
                    con.Width = (int)a;
                    a = System.Convert.ToSingle(myTag[1]) * newY;
                    con.Height = (int)a;
                    a = System.Convert.ToSingle(myTag[2]) * newX;
                    con.Left = (int)a;
                    a = System.Convert.ToSingle(myTag[3]) * newY;
                    con.Top = (int)a;
                    Single currentSize = System.Convert.ToSingle(myTag[4]) * newY;
                    con.Font = new System.Drawing.Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newX, newY, con);
                    }


                }
            }
            catch { }
        }
        /// <summary>
        /// 重新调整新界面的大小
        /// </summary>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="FormWidth"></param>
        /// <param name="FormHeight"></param>
        /// <param name="cons"></param>
        public void Resize(float Width, float Height, float FormWidth, float FormHeight, Control cons)
        {
            float newX = (Width) / FormWidth;
            float newY = (Height) / FormHeight;
            setControls(newX, newY, cons);
        }
    }
}
