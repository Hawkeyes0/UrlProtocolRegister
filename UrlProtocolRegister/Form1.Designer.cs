namespace UrlProtocolRegister
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUseParam = new System.Windows.Forms.CheckBox();
            this.tProtocol = new System.Windows.Forms.TextBox();
            this.tPath = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.fdBrowse = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "协议名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "关联程序";
            // 
            // cbUseParam
            // 
            this.cbUseParam.AutoSize = true;
            this.cbUseParam.Location = new System.Drawing.Point(90, 89);
            this.cbUseParam.Name = "cbUseParam";
            this.cbUseParam.Size = new System.Drawing.Size(90, 16);
            this.cbUseParam.TabIndex = 2;
            this.cbUseParam.Text = "使用参数(&U)";
            this.cbUseParam.UseVisualStyleBackColor = true;
            // 
            // tProtocol
            // 
            this.tProtocol.Location = new System.Drawing.Point(90, 12);
            this.tProtocol.Name = "tProtocol";
            this.tProtocol.Size = new System.Drawing.Size(157, 21);
            this.tProtocol.TabIndex = 3;
            // 
            // tPath
            // 
            this.tPath.Enabled = false;
            this.tPath.Location = new System.Drawing.Point(90, 48);
            this.tPath.Name = "tPath";
            this.tPath.Size = new System.Drawing.Size(398, 21);
            this.tPath.TabIndex = 4;
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(494, 46);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 5;
            this.bBrowse.Text = "浏览(&B)";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(386, 112);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 6;
            this.bOK.Text = "注册(&R)";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(494, 112);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "退出(&X)";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // fdBrowse
            // 
            this.fdBrowse.Filter = "可执行文件|*.exe";
            this.fdBrowse.Title = "选择文件";
            // 
            // Form1
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(581, 147);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.tPath);
            this.Controls.Add(this.tProtocol);
            this.Controls.Add(this.cbUseParam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "协议注册";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbUseParam;
        private System.Windows.Forms.TextBox tProtocol;
        private System.Windows.Forms.TextBox tPath;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.OpenFileDialog fdBrowse;
    }
}

