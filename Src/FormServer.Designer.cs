namespace SocketTalker
{
    partial class FormServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStartListen = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnStopListen = new System.Windows.Forms.Button();
            this.cmbServerIP = new System.Windows.Forms.ComboBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.groupListen = new System.Windows.Forms.GroupBox();
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.logger = new SocketTalker.Controls.Logger();
            this.groupSend = new System.Windows.Forms.GroupBox();
            this.cmbCoding = new SocketTalker.Controls.EncodingBox(this.components);
            this.encodingBox1 = new SocketTalker.Controls.EncodingBox(this.components);
            this.groupListen.SuspendLayout();
            this.groupLog.SuspendLayout();
            this.groupSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(446, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 100);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStartListen
            // 
            this.btnStartListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartListen.Location = new System.Drawing.Point(365, 19);
            this.btnStartListen.Name = "btnStartListen";
            this.btnStartListen.Size = new System.Drawing.Size(75, 23);
            this.btnStartListen.TabIndex = 9;
            this.btnStartListen.Text = "开始监听";
            this.btnStartListen.Click += new System.EventHandler(this.btnStartListen_Click);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(175, 47);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(265, 70);
            this.tbText.TabIndex = 1;
            // 
            // btnStopListen
            // 
            this.btnStopListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopListen.Location = new System.Drawing.Point(446, 19);
            this.btnStopListen.Name = "btnStopListen";
            this.btnStopListen.Size = new System.Drawing.Size(75, 23);
            this.btnStopListen.TabIndex = 8;
            this.btnStopListen.Text = "停止监听";
            this.btnStopListen.Click += new System.EventHandler(this.btnStopListen_Click);
            // 
            // cmbServerIP
            // 
            this.cmbServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServerIP.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.cmbServerIP.Location = new System.Drawing.Point(47, 20);
            this.cmbServerIP.Name = "cmbServerIP";
            this.cmbServerIP.Size = new System.Drawing.Size(121, 20);
            this.cmbServerIP.TabIndex = 7;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(187, 20);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(41, 21);
            this.tbServerPort.TabIndex = 3;
            this.tbServerPort.Text = "8080";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器";
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 12;
            this.lbClients.Location = new System.Drawing.Point(8, 17);
            this.lbClients.Name = "lbClients";
            this.lbClients.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbClients.Size = new System.Drawing.Size(161, 100);
            this.lbClients.TabIndex = 10;
            // 
            // groupListen
            // 
            this.groupListen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupListen.Controls.Add(this.cmbServerIP);
            this.groupListen.Controls.Add(this.tbServerPort);
            this.groupListen.Controls.Add(this.label2);
            this.groupListen.Controls.Add(this.btnStartListen);
            this.groupListen.Controls.Add(this.label1);
            this.groupListen.Controls.Add(this.btnStopListen);
            this.groupListen.Location = new System.Drawing.Point(4, 3);
            this.groupListen.Name = "groupListen";
            this.groupListen.Size = new System.Drawing.Size(527, 49);
            this.groupListen.TabIndex = 11;
            this.groupListen.TabStop = false;
            this.groupListen.Text = "Listen";
            // 
            // groupLog
            // 
            this.groupLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLog.Controls.Add(this.logger);
            this.groupLog.Location = new System.Drawing.Point(4, 189);
            this.groupLog.Name = "groupLog";
            this.groupLog.Size = new System.Drawing.Size(527, 369);
            this.groupLog.TabIndex = 13;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "Log";
            // 
            // logger
            // 
            this.logger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logger.Location = new System.Drawing.Point(3, 17);
            this.logger.Name = "logger";
            this.logger.Size = new System.Drawing.Size(521, 349);
            this.logger.TabIndex = 12;
            // 
            // groupSend
            // 
            this.groupSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSend.Controls.Add(this.cmbCoding);
            this.groupSend.Controls.Add(this.tbText);
            this.groupSend.Controls.Add(this.btnSend);
            this.groupSend.Controls.Add(this.lbClients);
            this.groupSend.Location = new System.Drawing.Point(4, 58);
            this.groupSend.Name = "groupSend";
            this.groupSend.Size = new System.Drawing.Size(527, 125);
            this.groupSend.TabIndex = 14;
            this.groupSend.TabStop = false;
            this.groupSend.Text = "Send";
            // 
            // cmbCoding
            // 
            this.cmbCoding.FormattingEnabled = true;
            this.cmbCoding.Location = new System.Drawing.Point(176, 16);
            this.cmbCoding.Name = "cmbCoding";
            this.cmbCoding.Size = new System.Drawing.Size(264, 20);
            this.cmbCoding.TabIndex = 11;
            this.cmbCoding.SelectedIndexChanged += new System.EventHandler(this.cmbEncoding_SelectedIndexChanged);
            // 
            // encodingBox1
            // 
            this.encodingBox1.FormattingEnabled = true;
            this.encodingBox1.Location = new System.Drawing.Point(176, 16);
            this.encodingBox1.Name = "encodingBox1";
            this.encodingBox1.Size = new System.Drawing.Size(264, 20);
            this.encodingBox1.TabIndex = 11;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.groupSend);
            this.Controls.Add(this.groupLog);
            this.Controls.Add(this.groupListen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormServer";
            this.Text = "Socket Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.groupListen.ResumeLayout(false);
            this.groupListen.PerformLayout();
            this.groupLog.ResumeLayout(false);
            this.groupSend.ResumeLayout(false);
            this.groupSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStartListen;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnStopListen;
        private System.Windows.Forms.ComboBox cmbServerIP;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.GroupBox groupListen;
        private Controls.Logger logger;
        private System.Windows.Forms.GroupBox groupLog;
        private System.Windows.Forms.GroupBox groupSend;
        private Controls.EncodingBox cmbCoding;
        private Controls.EncodingBox encodingBox1;
    }
}