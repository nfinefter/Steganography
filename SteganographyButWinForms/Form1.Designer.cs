
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
            this.imageChooser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Usermsg = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.userMessage = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.decryptedMessage = new System.Windows.Forms.TextBox();
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
            // imageChooser
            // 
            this.imageChooser.Location = new System.Drawing.Point(275, 12);
            this.imageChooser.Name = "imageChooser";
            this.imageChooser.Size = new System.Drawing.Size(80, 45);
            this.imageChooser.TabIndex = 1;
            this.imageChooser.Text = "Choose Image";
            this.imageChooser.UseVisualStyleBackColor = true;
            this.imageChooser.Click += new System.EventHandler(this.imageChooser_Click_1);
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
            this.confirmButton.Location = new System.Drawing.Point(275, 209);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(522, 54);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Encrypt";
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
            this.userMessage.Location = new System.Drawing.Point(275, 184);
            this.userMessage.Name = "userMessage";
            this.userMessage.Size = new System.Drawing.Size(522, 20);
            this.userMessage.TabIndex = 5;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(275, 98);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(522, 48);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // decryptedMessage
            // 
            this.decryptedMessage.Location = new System.Drawing.Point(275, 72);
            this.decryptedMessage.Name = "decryptedMessage";
            this.decryptedMessage.ReadOnly = true;
            this.decryptedMessage.Size = new System.Drawing.Size(522, 20);
            this.decryptedMessage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decryptedMessage);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.userMessage);
            this.Controls.Add(this.User);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.Usermsg);
            this.Controls.Add(this.imageChooser);
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
        private System.Windows.Forms.Button imageChooser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Usermsg;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox userMessage;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox decryptedMessage;
    }
}

