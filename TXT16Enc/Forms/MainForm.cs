using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

using Cheng.Algorithm.Encryptions.Char16;
using Cheng.Texts;
using Cheng.Windows.Forms;
using Cheng.Windows.Controls;

namespace Cheng.TXT16.Forms
{

    /// <summary>
    /// 主窗口
    /// </summary>
    public partial class MainForm : Form
    {

        public MainForm()
        {
            f_lastInit();
            InitializeComponent();
            f_init();
        }

        public MainForm(string[] args)
        {
            commandArgs = args;
            f_lastInit();
            InitializeComponent();
            f_init();
        }

        #region

        #region 释放

        private void f_disposeing(bool disposed)
        {

        }

        #endregion

        #region 初始化

        private void f_lastInit()
        {
            p_charBuf = new StringBuilder();
            p_c16Hash = new HashSet<char>(16, new CharValueEquality());
            p_charBufarr = new char[1024 * 4];
        }

        private void f_init()
        {
            Col_TextBox_TXT16_Origin.MaxLength = 65535;
            Col_TextBox_TXT16_Enc.MaxLength = 65535;
            Col_Button_TXT16_ToEnc.Click += fe_ButtonClick_Char16_ToEnc;
            Col_Button_TXT16_ToDec.Click += fe_ButtonClick_Char16_ToDec;
            Col_Button_Base64_ToEnc.Click += fe_ButtonClick_Base64_ToEnc;
            Col_Button_Base64_ToDec.Click += fe_ButtonClick_Base64_ToDec;

            //Col_Base64_Page;
            Col_TabControl.SelectedIndexChanged += fe_TabControl_SelectedIndexChanged;
            testBigFont();

            col_txt16_upDownTextBox.MoveTextBoxToUD();
            col_base64_upDownTextBox.MoveTextBoxToUD();
        }

        #endregion

        #region 参数

        private readonly string[] commandArgs;

        private StringBuilder p_charBuf;
        private char[] p_charBufarr;
        private HashSet<char> p_c16Hash;

        #endregion

        #region 控件

        #region 公共

        /// <summary>
        /// 控件 - 选项卡管理器
        /// </summary>
        private TabControl Col_TabControl
        {
            get => col_tabControl;
        }

        #endregion

        #region 16字真言控件

        /// <summary>
        /// 控件 - 页面分页 - 16字真言页面
        /// </summary>
        private TabPage Col_TXT16_Page
        {
            get => col_tabPage_txt16;
        }

        /// <summary>
        /// 控件 - 16字真言页面 - 原文本输入框
        /// </summary>
        private TextBox Col_TextBox_TXT16_Origin
        {
            get => col_txt16_upDownTextBox.Col_TextBox_Up;
        }

        /// <summary>
        /// 控件 - 16字真言页面 - 加密后文本输入框
        /// </summary>
        private TextBox Col_TextBox_TXT16_Enc
        {
            get => col_txt16_upDownTextBox.Col_TextBox_Down;
        }

        /// <summary>
        /// 控件 - 16字真言页面 - 16字真言输入框
        /// </summary>
        private TextBox Col_TextBox_TXT16_Char16
        {
            get => col_textBox_PageTXT16_Char16Input;
        }

        /// <summary>
        /// 控件 - 16字真言页面 - 加密↓按钮
        /// </summary>
        private Button Col_Button_TXT16_ToEnc
        {
            get => col_button_TXT16_toEnc;
        }

        /// <summary>
        /// 控件 - 16字真言页面 - 解密↑按钮
        /// </summary>
        private Button Col_Button_TXT16_ToDec
        {
            get => col_button_TXT16_Dec;
        }

        #endregion

        #region base64控件

        /// <summary>
        /// 控件 - base64页面
        /// </summary>
        private TabPage Col_Base64_Page
        {
            get => col_tabPage_base64;
        }

        /// <summary>
        /// 控件 - base64页面 - 原文本输入框
        /// </summary>
        private TextBox Col_TextBox_Base64_Origin
        {
            get => col_base64_upDownTextBox.Col_TextBox_Up;
        }

        /// <summary>
        /// 控件 - base64页面 - 加密后文本输入框
        /// </summary>
        private TextBox Col_TextBox_Base64_Enc
        {
            get => col_base64_upDownTextBox.Col_TextBox_Down;
        }

        /// <summary>
        /// 控件 - 16字真言页面 - 加密↓按钮
        /// </summary>
        private Button Col_Button_Base64_ToEnc
        {
            get => col_base64_button_toEnc;
        }

        /// <summary>
        /// 控件 - 16字真言页面 - 解密↑按钮
        /// </summary>
        private Button Col_Button_Base64_ToDec
        {
            get => col_base64_button_toDec;
        }

        #endregion

        #region

        #endregion

        #endregion

        #region 事件注册

        private void fe_testEvent(object sender, EventArgs args)
        {

        }

        #region 选项卡

        private void fe_TabControl_SelectedIndexChanged(object sender, EventArgs args)
        {
            var tab = Col_TabControl.SelectedTab;
            if (tab == Col_TXT16_Page)
            {
                col_txt16_upDownTextBox.MoveTextBoxToUD();
            }
            else if (tab == Col_Base64_Page)
            {
                col_base64_upDownTextBox.MoveTextBoxToUD();
            }
        }

        #endregion

        #region 16字真言页面

        /// <summary>
        /// 事件 - 16字真言页面 - 加密按钮: 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void fe_ButtonClick_Char16_ToEnc(object sender, EventArgs args)
        {
            f_ToEncChar16();
        }

        /// <summary>
        /// 事件 - 16字真言页面 - 解密按钮: 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void fe_ButtonClick_Char16_ToDec(object sender, EventArgs args)
        {
            f_ToDecChar16();
        }

        #endregion

        #region base64页面

        /// <summary>
        /// 事件 - base64页面 - 加密按钮: 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void fe_ButtonClick_Base64_ToEnc(object sender, EventArgs args)
        {
            f_ToEncBase64();
        }

        /// <summary>
        /// 事件 - base64页面 - 解密按钮: 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void fe_ButtonClick_Base64_ToDec(object sender, EventArgs args)
        {
            f_Base64ToDecText();
        }

        #endregion

        #endregion

        #region 功能

        #region 16字真言转化

        /// <summary>
        /// 从原文本框加密到16字真言文本框
        /// </summary>
        private void f_ToEncChar16()
        {
            //16字加密文本
            var char16 = Col_TextBox_TXT16_Char16.Text;
            if(char16.Length == 0)
            {
                this.ShowMegError("错误", "请在中间的输入框中输入16字真言！");
                return;
            }
            if(char16.Length != 16)
            {
                this.ShowMegError("错误", "16字真言必须要16个字符！");
                return;
            }

            //原文本
            var oriText = Col_TextBox_TXT16_Origin.Text;
            if(oriText.Length == 0)
            {
                this.ShowMegBox("提示", "请输入原文本", MessageBoxIcon.Warning, MessageBoxButtons.OK);
                return;
            }

            HashSet<char> hashset = p_c16Hash;
            hashset.Clear();
            for (int i = 0; i < 16; i++)
            {
                if (!hashset.Add(char16[i]))
                {
                    //有重复
                    hashset.Clear();
                    this.ShowMegError("错误", "16真言不能出现重复字符！");
                    return;
                }
            }

            if(!f_toEncChar16(oriText, Encoding.UTF8, char16, out string reText, out var ex))
            {
                //失败
                p_charBuf.Clear();
                p_charBuf
                    .AppendLine(ex.Message)
                    .Append("错误类型:")
                    .AppendLine(ex.GetType().FullName)
                    .Append("错误代码:")
                    .Append(ex.HResult)
                    ;
                this.ShowMegError("错误", p_charBuf.ToString());
                return;
            }

            //添加
            Col_TextBox_TXT16_Enc.Clear();
            Col_TextBox_TXT16_Enc.AppendText(reText);
        }

        /// <summary>
        /// 从密文文本框根据16字真言还原文本
        /// </summary>
        private void f_ToDecChar16()
        {
            //16字加密文本
            var char16 = Col_TextBox_TXT16_Char16.Text;
            if (char16.Length == 0)
            {
                this.ShowMegError("错误", "请在中间的输入框中输入16字真言！");
                return;
            }
            if (char16.Length != 16)
            {
                this.ShowMegError("错误", "16字真言必须要16个字符！");
                return;
            }

            //密文文本
            var oriText = Col_TextBox_TXT16_Enc.Text;
            if (oriText.Length == 0)
            {
                this.ShowMegBox("提示", "请输入密文", MessageBoxIcon.Warning, MessageBoxButtons.OK);
                return;
            }

            HashSet<char> hashset = p_c16Hash;
            hashset.Clear();
            for (int i = 0; i < 16; i++)
            {
                if (!hashset.Add(char16[i]))
                {
                    //有重复
                    hashset.Clear();
                    this.ShowMegError("错误", "16真言不能出现重复字符！");
                    return;
                }
            }

            if (!f_toC16DecText(oriText, char16, Encoding.UTF8, out string reText, out var ex))
            {
                //失败
                p_charBuf.Clear();
                p_charBuf
                    .AppendLine(ex.Message)
                    .Append("错误类型:")
                    .AppendLine(ex.GetType().FullName)
                    .Append("错误代码:")
                    .Append(ex.HResult)
                    ;
                this.ShowMegError("错误", p_charBuf.ToString());
                return;
            }

            //添加
            Col_TextBox_TXT16_Origin.Clear();
            Col_TextBox_TXT16_Origin.AppendText(reText);

        }

        static IReadOnlyDictionary<int, int> f_createDecTxtDire(IEnumerable<int> collection, Func<int, int> dictToKeyFunc, IEqualityComparer<int> keyEqualityComparer)
        {
            return System.Linq.Enumerable.ToDictionary(collection, dictToKeyFunc, keyEqualityComparer);
        }

        /// <summary>
        /// 将常规文本加密为16字真言
        /// </summary>
        /// <param name="text">待加密文本</param>
        /// <param name="encoding">文本编码</param>
        /// <param name="char16">16字真言</param>
        /// <param name="reC16">返回的加密文本</param>
        /// <param name="exception">可能的错误对象</param>
        /// <returns>是否成功</returns>
        private bool f_toEncChar16(string text, Encoding encoding, string char16, out string reC16, out Exception exception)
        {
            p_charBuf.Clear();
            exception = null;
            reC16 = null;
            try
            {
                using (Char16EecStreamWriter swr = new Char16EecStreamWriter(char16, new StringWriter(p_charBuf), true))
                {
                    using (StreamWriter streamWr = new StreamWriter(swr, encoding, 1024, true))
                    {
                        streamWr.Write(text);
                    }
                }
            }
            catch (Exception ex) 
            {
                exception = ex;
                return false;
            }
            reC16 = p_charBuf.ToString();
            return true;
        }

        /// <summary>
        /// 将16字真言的密文还原
        /// </summary>
        /// <param name="c16txt">16字真言密文</param>
        /// <param name="char16">16字真言</param>
        /// <param name="encoding">还原要用的文本编码</param>
        /// <param name="text">还原后的文本</param>
        /// <param name="exception">可能的错误</param>
        /// <returns>是否成功</returns>
        private bool f_toC16DecText(string c16txt, string char16, Encoding encoding, out string text, out Exception exception)
        {
            exception = null;
            text = null;
            try
            {
                using (Char16EncStreamReader c16r = new Char16EncStreamReader(char16.ToCharArray(), f_createDecTxtDire, new StringReader(c16txt), true))
                {
                    using (StreamReader dataReader = new StreamReader(c16r, encoding, false, 1024, true))
                    {
                        p_charBuf.Clear();
                        StringWriter strwr = new StringWriter(p_charBuf);
                        try
                        {
                            dataReader.CopyToText(strwr, p_charBufarr);
                        }
                        catch (NotImplementedException nie)
                        {
                            exception = new ArgumentException("解码时出现错误！", nie);
                            return false;
                        }
                       
                        strwr.Close();
                        text = p_charBuf.ToString();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }

        }

        #endregion

        #region base64转化


        private void f_ToEncBase64()
        {
            //原文本
            var oriText = Col_TextBox_Base64_Origin.Text;
            if (oriText.Length == 0)
            {
                this.ShowMegBox("提示", "请输入原文本", MessageBoxIcon.Warning, MessageBoxButtons.OK);
                return;
            }
            string toStr;
            try
            {
                toStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(oriText));
            }
            catch (Exception ex)
            {
                //失败
                p_charBuf.Clear();
                p_charBuf
                    .AppendLine(ex.Message)
                    .Append("错误类型:")
                    .AppendLine(ex.GetType().FullName)
                    .Append("错误代码:")
                    .Append(ex.HResult)
                    ;
                this.ShowMegError("错误", p_charBuf.ToString());
                return;
            }

            //添加
            Col_TextBox_Base64_Enc.Clear();
            Col_TextBox_Base64_Enc.AppendText(toStr);
        }


        private void f_Base64ToDecText()
        {
            //base64文本
            var oriText = Col_TextBox_Base64_Enc.Text;
            if (oriText.Length == 0)
            {
                this.ShowMegBox("提示", "请输入原文本", MessageBoxIcon.Warning, MessageBoxButtons.OK);
                return;
            }

            string toStr;
            try
            {
                toStr = Encoding.UTF8.GetString(Convert.FromBase64String(oriText));
            }
            catch (Exception ex)
            {
                //失败
                p_charBuf.Clear();
                p_charBuf
                    .AppendLine(ex.Message)
                    .Append("错误类型:")
                    .AppendLine(ex.GetType().FullName)
                    .Append("错误代码:")
                    .Append(ex.HResult)
                    ;
                this.ShowMegError("错误", p_charBuf.ToString());
                return;
            }
            //添加
            Col_TextBox_Base64_Origin.Clear();
            Col_TextBox_Base64_Origin.AppendText(toStr);
        }

        #endregion

        #region 配置文件

        private void testBigFont()
        {
            var font = Font;
            Font newF = new Font(font.FontFamily, font.Size * 1.25f, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            SetFont(newF);
        }

        private void SetFont(Font font)
        {
            col_base64_upDownTextBox.Font = font;
            col_txt16_upDownTextBox.Font = font;
            //this.Font = font;
        }

        #endregion

        #endregion

        #region 派生

        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            col_txt16_upDownTextBox.MoveTextBoxToUD();
            col_base64_upDownTextBox.MoveTextBoxToUD();
            base.OnResizeEnd(e);
        }

        #endregion

        #endregion

    }

}
