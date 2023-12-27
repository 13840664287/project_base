using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// IO信息表
    /// </summary>
    public class IOInformationEntity
    {
        /// <summary>
        /// IO的id
        /// </summary>
        private int id;
        /// <summary>
        /// IO的名称
        /// </summary>
        private string ioName;
        /// <summary>
        /// 开文字
        /// </summary>
        private string trueText;
        /// <summary>
        /// 关文字
        /// </summary>
        private string falseText;
        /// <summary>
        /// 类型
        /// </summary>
        private int ioType;
        /// <summary>
        /// 控制源
        /// </summary>
        private int control;
        /// <summary>
        /// 控制地址1
        /// </summary>
        private string addr1;
        /// <summary>
        /// 控制地址2
        /// </summary>
        private string addr2;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string IoName
        {
            get { return ioName; }
            set { ioName = value; }
        }

        public string TrueText
        {
            get { return trueText; }
            set { trueText = value; }
        }

        public string FalseText
        {
            get { return falseText; }
            set { falseText = value; }
        }

        public int IoType
        {
            get { return ioType; }
            set { ioType = value; }
        }

        public int Control
        {
            get { return control; }
            set { control = value; }
        }

        public string Addr1
        {
            get { return addr1; }
            set { addr1 = value; }
        }

        public string Addr2
        {
            get { return addr2; }
            set { addr2 = value; }
        }
    }
}
