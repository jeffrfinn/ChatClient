namespace Chat_Client
{
    partial class Chat
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
            this.ChatBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChatBox
            // 
            this.ChatBox.AcceptsTab = true;
            this.ChatBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatBox.Location = new System.Drawing.Point(0, 0);
            this.ChatBox.Multiline = true;
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(284, 221);
            this.ChatBox.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(197, 227);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(13, 230);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(128, 20);
            this.ServerName.TabIndex = 2;
            this.ServerName.Text = "Enter Server Name";
            this.ServerName.TextChanged += new System.EventHandler(this.SetServer);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.ChatBox);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox ServerName;
    }
}

