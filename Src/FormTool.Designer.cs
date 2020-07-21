namespace SocketTalker
{
    partial class FormTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTool));
            this.tbText1 = new System.Windows.Forms.TextBox();
            this.tbXorKey = new System.Windows.Forms.TextBox();
            this.btnXor = new System.Windows.Forms.Button();
            this.lblHex = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.encodingBox2 = new SocketTalker.Controls.EncodingBox(this.components);
            this.encodingBox1 = new SocketTalker.Controls.EncodingBox(this.components);
            this.tbText3 = new SocketTalker.Controls.TextBoxEx();
            this.tbText2 = new SocketTalker.Controls.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbText1
            // 
            this.tbText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbText1.Location = new System.Drawing.Point(12, 34);
            this.tbText1.Multiline = true;
            this.tbText1.Name = "tbText1";
            this.tbText1.Size = new System.Drawing.Size(233, 469);
            this.tbText1.TabIndex = 0;
            this.tbText1.Text = "{\"SN\":\"5555\",\"Humidity\":\"30\",\"Pressure\":\"40\",\"Temperature\":\"50\",\"Data1\":\"XXXXX\",\"" +
    "Data2\":\"XXXXX\",\"Status\":\"1\"}";
            // 
            // tbXorKey
            // 
            this.tbXorKey.Location = new System.Drawing.Point(612, 116);
            this.tbXorKey.Name = "tbXorKey";
            this.tbXorKey.Size = new System.Drawing.Size(96, 21);
            this.tbXorKey.TabIndex = 13;
            this.tbXorKey.Text = "MTK ";
            // 
            // btnXor
            // 
            this.btnXor.Location = new System.Drawing.Point(612, 169);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(96, 23);
            this.btnXor.TabIndex = 15;
            this.btnXor.Text = "XOR";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(13, 16);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(29, 12);
            this.lblHex.TabIndex = 16;
            this.lblHex.Text = "Text";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(251, 169);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(96, 23);
            this.btnEncode.TabIndex = 17;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // encodingBox2
            // 
            this.encodingBox2.FormattingEnabled = true;
            this.encodingBox2.Location = new System.Drawing.Point(612, 143);
            this.encodingBox2.Name = "encodingBox2";
            this.encodingBox2.Size = new System.Drawing.Size(95, 20);
            this.encodingBox2.TabIndex = 21;
            // 
            // encodingBox1
            // 
            this.encodingBox1.FormattingEnabled = true;
            this.encodingBox1.Location = new System.Drawing.Point(252, 143);
            this.encodingBox1.Name = "encodingBox1";
            this.encodingBox1.Size = new System.Drawing.Size(95, 20);
            this.encodingBox1.TabIndex = 20;
            // 
            // tbText3
            // 
            this.tbText3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbText3.Bytes = null;
            this.tbText3.Location = new System.Drawing.Point(714, 34);
            this.tbText3.Name = "tbText3";
            this.tbText3.Size = new System.Drawing.Size(253, 469);
            this.tbText3.TabIndex = 19;
            // 
            // tbText2
            // 
            this.tbText2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbText2.Bytes = null;
            this.tbText2.Location = new System.Drawing.Point(353, 34);
            this.tbText2.Name = "tbText2";
            this.tbText2.Size = new System.Drawing.Size(253, 469);
            this.tbText2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "Encoded";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "XORed";
            // 
            // FormTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encodingBox2);
            this.Controls.Add(this.encodingBox1);
            this.Controls.Add(this.tbText3);
            this.Controls.Add(this.tbText2);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.btnXor);
            this.Controls.Add(this.tbXorKey);
            this.Controls.Add(this.tbText1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTool";
            this.Text = "Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText1;
        private System.Windows.Forms.TextBox tbXorKey;
        private System.Windows.Forms.Button btnXor;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Button btnEncode;
        private Controls.TextBoxEx tbText2;
        private Controls.TextBoxEx tbText3;
        private Controls.EncodingBox encodingBox1;
        private Controls.EncodingBox encodingBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}