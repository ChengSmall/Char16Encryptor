using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheng.TXT16.Controls
{
    public partial class UpDownTextBox : UserControl
    {
        public UpDownTextBox()
        {
            f_lastInit();
            InitializeComponent();
            f_init();
        }

        #region

        #region 释放

        private void f_disposeing(bool disposeing)
        {

        }

        #endregion

        #region 初始化

        private void f_lastInit()
        {
        }

        private void f_init()
        {
            MoveTextBoxToUD();
        }

        #endregion

        #region 参数

        private readonly string[] commandArgs;

        #endregion

        #region 控件

        #region 文本框

        /// <summary>
        /// 控件 - 上方原文本输入框
        /// </summary>
        public TextBox Col_TextBox_Up
        {
            get => col_textBox_up;
        }

        /// <summary>
        /// 控件 - 下方原文本输入框
        /// </summary>
        public TextBox Col_TextBox_Down
        {
            get => col_textBox_down;
        }

        #endregion

        #region

        #endregion

        #endregion

        #region 事件注册

        #endregion

        #region 功能

        /// <summary>
        /// 将上下两文本框复位
        /// </summary>
        public void MoveTextBoxToUD()
        {
            var tup = Col_TextBox_Up;
            var td = Col_TextBox_Down;
            var psize = this.Size;

            double hs2 = psize.Height / 2d;

            tup.Location = new Point(0, 0);
            tup.Size = new Size(psize.Width, (int)(hs2 - 10));
            td.Location = new Point(0, (int)(hs2 + 10));
            td.Size = new Size(psize.Width, (int)(hs2 - 10));
        }

        #endregion

        #region 派生

        private void test()
        {
            //this.SizeChanged
            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        #endregion

        #endregion


    }
}
