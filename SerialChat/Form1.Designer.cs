namespace SeirialChat
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btConfig = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 321);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(650, 25);
            this.tb1.TabIndex = 0;
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConnect.Location = new System.Drawing.Point(12, 352);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(114, 50);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSend.Location = new System.Drawing.Point(144, 352);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(114, 50);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btClose.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btClose.Location = new System.Drawing.Point(548, 352);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(114, 50);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // btConfig
            // 
            this.btConfig.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConfig.Location = new System.Drawing.Point(363, 359);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(116, 37);
            this.btConfig.TabIndex = 5;
            this.btConfig.Text = "Configuration";
            this.btConfig.UseVisualStyleBackColor = false;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb2.Font = new System.Drawing.Font("굴림", 10F);
            this.tb2.ForeColor = System.Drawing.Color.Lime;
            this.tb2.Location = new System.Drawing.Point(12, 12);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(650, 303);
            this.tb2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(678, 409);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tb1);
            this.Name = "Form1";
            this.Text = "Serial Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btClose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.TextBox tb2;
    }
}

