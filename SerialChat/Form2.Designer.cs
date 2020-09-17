namespace SeirialChat
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.tbDbit = new System.Windows.Forms.TextBox();
            this.cbSbit = new System.Windows.Forms.ComboBox();
            this.cbP = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(44, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(104, 18);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 23);
            this.cbPort.TabIndex = 5;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(104, 58);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 23);
            this.cbBaud.TabIndex = 6;
            // 
            // tbDbit
            // 
            this.tbDbit.Location = new System.Drawing.Point(104, 95);
            this.tbDbit.Name = "tbDbit";
            this.tbDbit.Size = new System.Drawing.Size(45, 25);
            this.tbDbit.TabIndex = 7;
            this.tbDbit.Text = "8";
            // 
            // cbSbit
            // 
            this.cbSbit.FormattingEnabled = true;
            this.cbSbit.Items.AddRange(new object[] {
            "One",
            "Two",
            "None",
            "OnePointFive"});
            this.cbSbit.Location = new System.Drawing.Point(104, 132);
            this.cbSbit.Name = "cbSbit";
            this.cbSbit.Size = new System.Drawing.Size(85, 23);
            this.cbSbit.TabIndex = 8;
            // 
            // cbP
            // 
            this.cbP.FormattingEnabled = true;
            this.cbP.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "Mark",
            "Space",
            "None"});
            this.cbP.Location = new System.Drawing.Point(104, 172);
            this.cbP.Name = "cbP";
            this.cbP.Size = new System.Drawing.Size(85, 23);
            this.cbP.TabIndex = 9;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(31, 217);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(76, 40);
            this.btOK.TabIndex = 10;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCl
            // 
            this.btCl.Location = new System.Drawing.Point(149, 217);
            this.btCl.Name = "btCl";
            this.btCl.Size = new System.Drawing.Size(76, 40);
            this.btCl.TabIndex = 11;
            this.btCl.Text = "Close";
            this.btCl.UseVisualStyleBackColor = true;
            this.btCl.Click += new System.EventHandler(this.btCl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(244, 274);
            this.Controls.Add(this.btCl);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbP);
            this.Controls.Add(this.cbSbit);
            this.Controls.Add(this.tbDbit);
            this.Controls.Add(this.cbBaud);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.TextBox tbDbit;
        private System.Windows.Forms.ComboBox cbSbit;
        private System.Windows.Forms.ComboBox cbP;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCl;
    }
}