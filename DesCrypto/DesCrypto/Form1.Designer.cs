
namespace DesCrypto
{
    partial class MainForm
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
            this.keyButton = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.ivLabel = new System.Windows.Forms.Label();
            this.ivButton = new System.Windows.Forms.Button();
            this.plainLabel = new System.Windows.Forms.Label();
            this.plainText = new System.Windows.Forms.TextBox();
            this.encryptedTxt = new System.Windows.Forms.TextBox();
            this.decryptedTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.githubButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keyButton
            // 
            this.keyButton.Location = new System.Drawing.Point(12, 12);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(119, 38);
            this.keyButton.TabIndex = 0;
            this.keyButton.Text = "Generate Key";
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(159, 23);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(152, 17);
            this.keyLabel.TabIndex = 1;
            this.keyLabel.Text = "Key not generated yet.";
            // 
            // ivLabel
            // 
            this.ivLabel.AutoSize = true;
            this.ivLabel.Location = new System.Drawing.Point(159, 77);
            this.ivLabel.Name = "ivLabel";
            this.ivLabel.Size = new System.Drawing.Size(140, 17);
            this.ivLabel.TabIndex = 3;
            this.ivLabel.Text = "IV not generated yet.";
            // 
            // ivButton
            // 
            this.ivButton.Location = new System.Drawing.Point(12, 66);
            this.ivButton.Name = "ivButton";
            this.ivButton.Size = new System.Drawing.Size(119, 38);
            this.ivButton.TabIndex = 2;
            this.ivButton.Text = "Generate IV";
            this.ivButton.UseVisualStyleBackColor = true;
            this.ivButton.Click += new System.EventHandler(this.ivButton_Click);
            // 
            // plainLabel
            // 
            this.plainLabel.AutoSize = true;
            this.plainLabel.Location = new System.Drawing.Point(2, 137);
            this.plainLabel.Name = "plainLabel";
            this.plainLabel.Size = new System.Drawing.Size(78, 17);
            this.plainLabel.TabIndex = 4;
            this.plainLabel.Text = "Plain Text :";
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(89, 137);
            this.plainText.Multiline = true;
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(564, 93);
            this.plainText.TabIndex = 5;
            // 
            // encryptedTxt
            // 
            this.encryptedTxt.Location = new System.Drawing.Point(89, 236);
            this.encryptedTxt.Multiline = true;
            this.encryptedTxt.Name = "encryptedTxt";
            this.encryptedTxt.ReadOnly = true;
            this.encryptedTxt.Size = new System.Drawing.Size(564, 93);
            this.encryptedTxt.TabIndex = 6;
            // 
            // decryptedTxt
            // 
            this.decryptedTxt.Location = new System.Drawing.Point(89, 335);
            this.decryptedTxt.Multiline = true;
            this.decryptedTxt.Name = "decryptedTxt";
            this.decryptedTxt.ReadOnly = true;
            this.decryptedTxt.Size = new System.Drawing.Size(564, 93);
            this.decryptedTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Encrypted :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Decrypted :";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(347, 434);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(150, 66);
            this.encryptButton.TabIndex = 10;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(503, 434);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(150, 66);
            this.decryptButton.TabIndex = 11;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // githubButton
            // 
            this.githubButton.Location = new System.Drawing.Point(503, 12);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(140, 92);
            this.githubButton.TabIndex = 12;
            this.githubButton.Text = "Open Github Page";
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 507);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptedTxt);
            this.Controls.Add(this.encryptedTxt);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.plainLabel);
            this.Controls.Add(this.ivLabel);
            this.Controls.Add(this.ivButton);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DesCrypto (github.com/dincersipka)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label ivLabel;
        private System.Windows.Forms.Button ivButton;
        private System.Windows.Forms.Label plainLabel;
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.TextBox encryptedTxt;
        private System.Windows.Forms.TextBox decryptedTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button githubButton;
    }
}

