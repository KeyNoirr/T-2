namespace ChatFrom
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
            this.labMessage = new System.Windows.Forms.Label();
            this.btnFiles = new System.Windows.Forms.Button();
            this.btnMusics = new System.Windows.Forms.Button();
            this.btnImages = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMassage = new System.Windows.Forms.TextBox();
            this.listBChat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Location = new System.Drawing.Point(58, 266);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(50, 13);
            this.labMessage.TabIndex = 1;
            this.labMessage.Text = "Massage";
            // 
            // btnFiles
            // 
            this.btnFiles.Location = new System.Drawing.Point(651, 48);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(88, 39);
            this.btnFiles.TabIndex = 2;
            this.btnFiles.Text = "Flies";
            this.btnFiles.UseVisualStyleBackColor = true;
            // 
            // btnMusics
            // 
            this.btnMusics.Location = new System.Drawing.Point(651, 125);
            this.btnMusics.Name = "btnMusics";
            this.btnMusics.Size = new System.Drawing.Size(88, 39);
            this.btnMusics.TabIndex = 3;
            this.btnMusics.Text = "Musics";
            this.btnMusics.UseVisualStyleBackColor = true;
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(651, 208);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(88, 39);
            this.btnImages.TabIndex = 4;
            this.btnImages.Text = "Images";
            this.btnImages.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(635, 313);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 63);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMassage
            // 
            this.txtMassage.Location = new System.Drawing.Point(61, 293);
            this.txtMassage.Multiline = true;
            this.txtMassage.Name = "txtMassage";
            this.txtMassage.Size = new System.Drawing.Size(535, 105);
            this.txtMassage.TabIndex = 7;
            // 
            // listBChat
            // 
            this.listBChat.FormattingEnabled = true;
            this.listBChat.Location = new System.Drawing.Point(61, 48);
            this.listBChat.Name = "listBChat";
            this.listBChat.Size = new System.Drawing.Size(534, 199);
            this.listBChat.TabIndex = 8;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBChat);
            this.Controls.Add(this.txtMassage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.btnMusics);
            this.Controls.Add(this.btnFiles);
            this.Controls.Add(this.labMessage);
            this.Name = "Frm";
            this.Text = "Chat Form";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.Button btnMusics;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMassage;
        private System.Windows.Forms.ListBox listBChat;
    }
}

