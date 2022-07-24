
namespace Server
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.clientIPListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(272, 337);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(77, 50);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(189, 337);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(77, 50);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(12, 60);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(313, 20);
            this.ipTextBox.TabIndex = 2;
            this.ipTextBox.Text = "127.0.0.1:9000";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 306);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(313, 20);
            this.messageTextBox.TabIndex = 3;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 95);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(313, 205);
            this.infoTextBox.TabIndex = 4;
            // 
            // clientIPListBox
            // 
            this.clientIPListBox.FormattingEnabled = true;
            this.clientIPListBox.Location = new System.Drawing.Point(359, 95);
            this.clientIPListBox.Name = "clientIPListBox";
            this.clientIPListBox.Size = new System.Drawing.Size(165, 212);
            this.clientIPListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientIPListBox);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.ListBox clientIPListBox;
    }
}

