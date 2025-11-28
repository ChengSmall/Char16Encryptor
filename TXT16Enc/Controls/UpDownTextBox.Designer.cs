
namespace Cheng.TXT16.Controls
{
    partial class UpDownTextBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            f_disposeing(disposing);

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.col_textBox_up = new System.Windows.Forms.TextBox();
            this.col_textBox_down = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // col_textBox_up
            // 
            this.col_textBox_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.col_textBox_up.Location = new System.Drawing.Point(0, 0);
            this.col_textBox_up.Multiline = true;
            this.col_textBox_up.Name = "col_textBox_up";
            this.col_textBox_up.Size = new System.Drawing.Size(600, 190);
            this.col_textBox_up.TabIndex = 0;
            // 
            // col_textBox_down
            // 
            this.col_textBox_down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.col_textBox_down.Location = new System.Drawing.Point(0, 210);
            this.col_textBox_down.Multiline = true;
            this.col_textBox_down.Name = "col_textBox_down";
            this.col_textBox_down.Size = new System.Drawing.Size(600, 190);
            this.col_textBox_down.TabIndex = 1;
            // 
            // UpDownTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.col_textBox_down);
            this.Controls.Add(this.col_textBox_up);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "UpDownTextBox";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox col_textBox_up;
        private System.Windows.Forms.TextBox col_textBox_down;
    }
}
