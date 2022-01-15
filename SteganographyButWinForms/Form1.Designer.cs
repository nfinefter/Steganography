
namespace SteganographyButWinForms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Usermsg = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.userMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 192);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Usermsg
            // 
            this.Usermsg.AutoSize = true;
            this.Usermsg.Location = new System.Drawing.Point(26, 230);
            this.Usermsg.Name = "Usermsg";
            this.Usermsg.Size = new System.Drawing.Size(0, 13);
            this.Usermsg.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(19, 253);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(71, 54);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm Message";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(26, 234);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(0, 13);
            this.User.TabIndex = 4;
            // 
            // userMessage
            // 
            this.userMessage.Location = new System.Drawing.Point(20, 233);
            this.userMessage.Name = "userMessage";
            this.userMessage.Size = new System.Drawing.Size(69, 20);
            this.userMessage.TabIndex = 5;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userMessage);
            this.Controls.Add(this.User);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.Usermsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Usermsg;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox userMessage;
    }
}

