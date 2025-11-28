
namespace Cheng.TXT16.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            f_disposeing(disposing);

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.col_formMenu = new System.Windows.Forms.MenuStrip();
            this.col_tabControl = new System.Windows.Forms.TabControl();
            this.col_tabPage_txt16 = new System.Windows.Forms.TabPage();
            this.col_txt16_upDownTextBox = new Cheng.TXT16.Controls.UpDownTextBox();
            this.col_textBox_PageTXT16_Char16Input = new System.Windows.Forms.TextBox();
            this.col_button_TXT16_Dec = new System.Windows.Forms.Button();
            this.col_button_TXT16_toEnc = new System.Windows.Forms.Button();
            this.col_tabPage_base64 = new System.Windows.Forms.TabPage();
            this.col_base64_upDownTextBox = new Cheng.TXT16.Controls.UpDownTextBox();
            this.col_base64_button_toDec = new System.Windows.Forms.Button();
            this.col_base64_button_toEnc = new System.Windows.Forms.Button();
            this.col_tabControl.SuspendLayout();
            this.col_tabPage_txt16.SuspendLayout();
            this.col_tabPage_base64.SuspendLayout();
            this.SuspendLayout();
            // 
            // col_formMenu
            // 
            this.col_formMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.col_formMenu.Location = new System.Drawing.Point(0, 0);
            this.col_formMenu.Name = "col_formMenu";
            this.col_formMenu.Size = new System.Drawing.Size(942, 24);
            this.col_formMenu.TabIndex = 0;
            this.col_formMenu.Text = "formMenu";
            // 
            // col_tabControl
            // 
            this.col_tabControl.Controls.Add(this.col_tabPage_txt16);
            this.col_tabControl.Controls.Add(this.col_tabPage_base64);
            this.col_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.col_tabControl.Location = new System.Drawing.Point(0, 24);
            this.col_tabControl.Name = "col_tabControl";
            this.col_tabControl.SelectedIndex = 0;
            this.col_tabControl.Size = new System.Drawing.Size(942, 649);
            this.col_tabControl.TabIndex = 1;
            // 
            // col_tabPage_txt16
            // 
            this.col_tabPage_txt16.Controls.Add(this.col_txt16_upDownTextBox);
            this.col_tabPage_txt16.Controls.Add(this.col_textBox_PageTXT16_Char16Input);
            this.col_tabPage_txt16.Controls.Add(this.col_button_TXT16_Dec);
            this.col_tabPage_txt16.Controls.Add(this.col_button_TXT16_toEnc);
            this.col_tabPage_txt16.Location = new System.Drawing.Point(4, 25);
            this.col_tabPage_txt16.Name = "col_tabPage_txt16";
            this.col_tabPage_txt16.Padding = new System.Windows.Forms.Padding(3);
            this.col_tabPage_txt16.Size = new System.Drawing.Size(934, 620);
            this.col_tabPage_txt16.TabIndex = 0;
            this.col_tabPage_txt16.Text = "16字真言加密";
            this.col_tabPage_txt16.UseVisualStyleBackColor = true;
            // 
            // col_txt16_upDownTextBox
            // 
            this.col_txt16_upDownTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.col_txt16_upDownTextBox.Location = new System.Drawing.Point(8, 81);
            this.col_txt16_upDownTextBox.MinimumSize = new System.Drawing.Size(300, 300);
            this.col_txt16_upDownTextBox.Name = "col_txt16_upDownTextBox";
            this.col_txt16_upDownTextBox.Size = new System.Drawing.Size(918, 525);
            this.col_txt16_upDownTextBox.TabIndex = 5;
            // 
            // col_textBox_PageTXT16_Char16Input
            // 
            this.col_textBox_PageTXT16_Char16Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.col_textBox_PageTXT16_Char16Input.Location = new System.Drawing.Point(257, 39);
            this.col_textBox_PageTXT16_Char16Input.MaxLength = 16;
            this.col_textBox_PageTXT16_Char16Input.Name = "col_textBox_PageTXT16_Char16Input";
            this.col_textBox_PageTXT16_Char16Input.Size = new System.Drawing.Size(419, 25);
            this.col_textBox_PageTXT16_Char16Input.TabIndex = 4;
            this.col_textBox_PageTXT16_Char16Input.Text = "请输入16字真言";
            this.col_textBox_PageTXT16_Char16Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // col_button_TXT16_Dec
            // 
            this.col_button_TXT16_Dec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.col_button_TXT16_Dec.Location = new System.Drawing.Point(733, 14);
            this.col_button_TXT16_Dec.Name = "col_button_TXT16_Dec";
            this.col_button_TXT16_Dec.Size = new System.Drawing.Size(108, 50);
            this.col_button_TXT16_Dec.TabIndex = 3;
            this.col_button_TXT16_Dec.Text = "还原↑";
            this.col_button_TXT16_Dec.UseVisualStyleBackColor = true;
            // 
            // col_button_TXT16_toEnc
            // 
            this.col_button_TXT16_toEnc.Location = new System.Drawing.Point(86, 14);
            this.col_button_TXT16_toEnc.Name = "col_button_TXT16_toEnc";
            this.col_button_TXT16_toEnc.Size = new System.Drawing.Size(108, 50);
            this.col_button_TXT16_toEnc.TabIndex = 2;
            this.col_button_TXT16_toEnc.Text = "加密↓";
            this.col_button_TXT16_toEnc.UseVisualStyleBackColor = true;
            // 
            // col_tabPage_base64
            // 
            this.col_tabPage_base64.Controls.Add(this.col_base64_upDownTextBox);
            this.col_tabPage_base64.Controls.Add(this.col_base64_button_toDec);
            this.col_tabPage_base64.Controls.Add(this.col_base64_button_toEnc);
            this.col_tabPage_base64.Location = new System.Drawing.Point(4, 25);
            this.col_tabPage_base64.Name = "col_tabPage_base64";
            this.col_tabPage_base64.Padding = new System.Windows.Forms.Padding(3);
            this.col_tabPage_base64.Size = new System.Drawing.Size(934, 620);
            this.col_tabPage_base64.TabIndex = 1;
            this.col_tabPage_base64.Text = "base64加密";
            this.col_tabPage_base64.UseVisualStyleBackColor = true;
            // 
            // col_base64_upDownTextBox
            // 
            this.col_base64_upDownTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.col_base64_upDownTextBox.Location = new System.Drawing.Point(8, 81);
            this.col_base64_upDownTextBox.MinimumSize = new System.Drawing.Size(300, 300);
            this.col_base64_upDownTextBox.Name = "col_base64_upDownTextBox";
            this.col_base64_upDownTextBox.Size = new System.Drawing.Size(918, 525);
            this.col_base64_upDownTextBox.TabIndex = 8;
            // 
            // col_base64_button_toDec
            // 
            this.col_base64_button_toDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.col_base64_button_toDec.Location = new System.Drawing.Point(733, 14);
            this.col_base64_button_toDec.Name = "col_base64_button_toDec";
            this.col_base64_button_toDec.Size = new System.Drawing.Size(108, 50);
            this.col_base64_button_toDec.TabIndex = 7;
            this.col_base64_button_toDec.Text = "还原↑";
            this.col_base64_button_toDec.UseVisualStyleBackColor = true;
            // 
            // col_base64_button_toEnc
            // 
            this.col_base64_button_toEnc.Location = new System.Drawing.Point(86, 14);
            this.col_base64_button_toEnc.Name = "col_base64_button_toEnc";
            this.col_base64_button_toEnc.Size = new System.Drawing.Size(108, 50);
            this.col_base64_button_toEnc.TabIndex = 6;
            this.col_base64_button_toEnc.Text = "加密↓";
            this.col_base64_button_toEnc.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 673);
            this.Controls.Add(this.col_tabControl);
            this.Controls.Add(this.col_formMenu);
            this.MainMenuStrip = this.col_formMenu;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "16字真言加密器";
            this.col_tabControl.ResumeLayout(false);
            this.col_tabPage_txt16.ResumeLayout(false);
            this.col_tabPage_txt16.PerformLayout();
            this.col_tabPage_base64.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip col_formMenu;
        private System.Windows.Forms.TabControl col_tabControl;
        private System.Windows.Forms.TabPage col_tabPage_txt16;
        private System.Windows.Forms.TabPage col_tabPage_base64;
        private System.Windows.Forms.Button col_button_TXT16_Dec;
        private System.Windows.Forms.Button col_button_TXT16_toEnc;
        private System.Windows.Forms.TextBox col_textBox_PageTXT16_Char16Input;
        private Controls.UpDownTextBox col_txt16_upDownTextBox;
        private Controls.UpDownTextBox col_base64_upDownTextBox;
        private System.Windows.Forms.Button col_base64_button_toDec;
        private System.Windows.Forms.Button col_base64_button_toEnc;
    }
}