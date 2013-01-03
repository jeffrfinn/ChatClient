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
            this.Send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // added manualy
            this.backgroundSend = new System.ComponentModel.BackgroundWorker();
           
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(197, 227);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.SendMsgBtn);
            
            // manualy added
            this.backgroundSend.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SendMessage);
                        
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Enter Text Here";
            // 
            // ChatBox
            // 
            this.ChatBox.AcceptsTab = true;
            this.ChatBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatBox.Location = new System.Drawing.Point(0, 0);
            this.ChatBox.Multiline = true;
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(284, 171);
            this.ChatBox.TabIndex = 0;
            this.ChatBox.Text = "Connecting to Server";

            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.ChatBox);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ChatBox;
    }
}

