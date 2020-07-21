namespace SocketTalker
{
    partial class FormClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.groupConnect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.groupSend = new System.Windows.Forms.GroupBox();
            this.cmbCoding = new SocketTalker.Controls.EncodingBox(this.components);
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.logger = new SocketTalker.Controls.Logger();
            this.encodingBox1 = new SocketTalker.Controls.EncodingBox(this.components);
            this.groupConnect.SuspendLayout();
            this.groupSend.SuspendLayout();
            this.groupLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupConnect
            // 
            this.groupConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConnect.Controls.Add(this.label1);
            this.groupConnect.Controls.Add(this.btnConnect);
            this.groupConnect.Controls.Add(this.btnDisconnect);
            this.groupConnect.Controls.Add(this.tbServerPort);
            this.groupConnect.Controls.Add(this.label3);
            this.groupConnect.Controls.Add(this.tbServerIP);
            this.groupConnect.Controls.Add(this.label4);
            this.groupConnect.Location = new System.Drawing.Point(5, 4);
            this.groupConnect.Name = "groupConnect";
            this.groupConnect.Size = new System.Drawing.Size(524, 54);
            this.groupConnect.TabIndex = 7;
            this.groupConnect.TabStop = false;
            this.groupConnect.Text = "Connect";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(359, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "请求连接";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Location = new System.Drawing.Point(440, 20);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "断开连接";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(212, 20);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(43, 21);
            this.tbServerPort.TabIndex = 3;
            this.tbServerPort.Text = "8080";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(198, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(69, 20);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(123, 21);
            this.tbServerIP.TabIndex = 1;
            this.tbServerIP.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "服务器";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(440, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 108);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(7, 47);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(427, 82);
            this.tbText.TabIndex = 4;
            // 
            // groupSend
            // 
            this.groupSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSend.Controls.Add(this.cmbCoding);
            this.groupSend.Controls.Add(this.tbText);
            this.groupSend.Controls.Add(this.btnSend);
            this.groupSend.Location = new System.Drawing.Point(5, 64);
            this.groupSend.Name = "groupSend";
            this.groupSend.Size = new System.Drawing.Size(524, 138);
            this.groupSend.TabIndex = 8;
            this.groupSend.TabStop = false;
            this.groupSend.Text = "Send";
            // 
            // cmbCoding
            // 
            this.cmbCoding.FormattingEnabled = true;
            this.cmbCoding.Location = new System.Drawing.Point(7, 21);
            this.cmbCoding.Name = "cmbCoding";
            this.cmbCoding.Size = new System.Drawing.Size(427, 20);
            this.cmbCoding.TabIndex = 6;
            // 
            // groupLog
            // 
            this.groupLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLog.Controls.Add(this.logger);
            this.groupLog.Location = new System.Drawing.Point(5, 208);
            this.groupLog.Name = "groupLog";
            this.groupLog.Size = new System.Drawing.Size(524, 353);
            this.groupLog.TabIndex = 14;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "Log";
            // 
            // logger
            // 
            this.logger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logger.Location = new System.Drawing.Point(3, 17);
            this.logger.Name = "logger";
            this.logger.Size = new System.Drawing.Size(518, 333);
            this.logger.TabIndex = 12;
            // 
            // encodingBox1
            // 
            this.encodingBox1.FormattingEnabled = true;
            this.encodingBox1.Location = new System.Drawing.Point(7, 21);
            this.encodingBox1.Name = "encodingBox1";
            this.encodingBox1.Size = new System.Drawing.Size(427, 20);
            this.encodingBox1.TabIndex = 6;
            this.encodingBox1.SelectedIndexChanged += new System.EventHandler(this.cmbEncoding_SelectedIndexChanged);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.groupLog);
            this.Controls.Add(this.groupSend);
            this.Controls.Add(this.groupConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClient";
            this.Text = "Socket Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClient_FormClosing);
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupConnect.ResumeLayout(false);
            this.groupConnect.PerformLayout();
            this.groupSend.ResumeLayout(false);
            this.groupSend.PerformLayout();
            this.groupLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupSend;
        private System.Windows.Forms.GroupBox groupLog;
        private Controls.Logger logger;
        private Controls.EncodingBox cmbCoding;
        private Controls.EncodingBox encodingBox1;
    }
}