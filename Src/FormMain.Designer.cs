namespace SocketTalker
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.lnk = new System.Windows.Forms.LinkLabel();
            this.btnTool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(24, 23);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(126, 55);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "开启Socket服务器";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(187, 23);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(133, 55);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "开启Socket客户端";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // lnk
            // 
            this.lnk.AutoSize = true;
            this.lnk.Location = new System.Drawing.Point(111, 105);
            this.lnk.Name = "lnk";
            this.lnk.Size = new System.Drawing.Size(209, 12);
            this.lnk.TabIndex = 2;
            this.lnk.TabStop = true;
            this.lnk.Text = "2016-02 http://surfsky.cnblogs.com";
            this.lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_LinkClicked);
            // 
            // btnTool
            // 
            this.btnTool.Location = new System.Drawing.Point(339, 23);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(115, 55);
            this.btnTool.TabIndex = 3;
            this.btnTool.Text = "工具";
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 126);
            this.Controls.Add(this.btnTool);
            this.Controls.Add(this.lnk);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocketTalker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.LinkLabel lnk;
        private System.Windows.Forms.Button btnTool;
    }
}