namespace ClientFrom
{
    partial class Frm
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
            this.listBChat = new System.Windows.Forms.ListBox();
            this.txtMassage = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnImages = new System.Windows.Forms.Button();
            this.btnMusics = new System.Windows.Forms.Button();
            this.btnFiles = new System.Windows.Forms.Button();
            this.labMessage = new System.Windows.Forms.Label();
            this.labIP = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBChat
            // 
            this.listBChat.FormattingEnabled = true;
            this.listBChat.Location = new System.Drawing.Point(63, 68);
            this.listBChat.Name = "listBChat";
            this.listBChat.Size = new System.Drawing.Size(534, 199);
            this.listBChat.TabIndex = 17;
            // 
            // txtMassage
            // 
            this.txtMassage.Location = new System.Drawing.Point(63, 313);
            this.txtMassage.Multiline = true;
            this.txtMassage.Name = "txtMassage";
            this.txtMassage.Size = new System.Drawing.Size(535, 105);
            this.txtMassage.TabIndex = 16;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(112, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(250, 20);
            this.txtIP.TabIndex = 15;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(637, 333);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 63);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(653, 228);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(88, 39);
            this.btnImages.TabIndex = 13;
            this.btnImages.Text = "Images";
            this.btnImages.UseVisualStyleBackColor = true;
            // 
            // btnMusics
            // 
            this.btnMusics.Location = new System.Drawing.Point(653, 145);
            this.btnMusics.Name = "btnMusics";
            this.btnMusics.Size = new System.Drawing.Size(88, 39);
            this.btnMusics.TabIndex = 12;
            this.btnMusics.Text = "Musics";
            this.btnMusics.UseVisualStyleBackColor = true;
            // 
            // btnFiles
            // 
            this.btnFiles.Location = new System.Drawing.Point(653, 68);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(88, 39);
            this.btnFiles.TabIndex = 11;
            this.btnFiles.Text = "Flies";
            this.btnFiles.UseVisualStyleBackColor = true;
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Location = new System.Drawing.Point(60, 286);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(50, 13);
            this.labMessage.TabIndex = 10;
            this.labMessage.Text = "Massage";
            // 
            // labIP
            // 
            this.labIP.AutoSize = true;
            this.labIP.Location = new System.Drawing.Point(60, 35);
            this.labIP.Name = "labIP";
            this.labIP.Size = new System.Drawing.Size(46, 13);
            this.labIP.TabIndex = 9;
            this.labIP.Text = "Client IP";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(404, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.listBChat);
            this.Controls.Add(this.txtMassage);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.btnMusics);
            this.Controls.Add(this.btnFiles);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.labIP);
            this.Name = "Frm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBChat;
        private System.Windows.Forms.TextBox txtMassage;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.Button btnMusics;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.Label labIP;
        private System.Windows.Forms.Button btnConnect;
    }
}

