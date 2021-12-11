using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesCrypto
{
    public partial class MainForm : Form
    {
        private Crypto Crypto;
        private string KEY, IV;

        public MainForm()
        {
            InitializeComponent();
            Crypto = new Crypto();
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            KEY = Crypto.GenerateKey();
            keyLabel.Text = this.KEY;

            encryptedTxt.Text = "";
            decryptedTxt.Text = "";
        }

        private void ivButton_Click(object sender, EventArgs e)
        {
            IV = Crypto.GenerateIV();
            ivLabel.Text = IV;

            encryptedTxt.Text = "";
            decryptedTxt.Text = "";
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.KEY) || String.IsNullOrEmpty(this.IV))
            {
                MessageBox.Show("Key or IV not generated yet.", "Error");
            }
            else 
            {
                if (String.IsNullOrEmpty(plainText.Text))
                {
                    MessageBox.Show("Plain Text is null or empty.", "Error");
                }
                else 
                {
                    encryptedTxt.Text = Crypto.Encrypt(plainText.Text);
                    plainText.Text = "";
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.KEY) || String.IsNullOrEmpty(this.IV))
            {
                MessageBox.Show("Key or IV not generated yet.", "Error");
            }
            else
            {
                if (String.IsNullOrEmpty(encryptedTxt.Text))
                {
                    MessageBox.Show("Encrypted Text is null or empty.", "Error");
                }
                else
                {
                    decryptedTxt.Text = Crypto.Decrypt(encryptedTxt.Text);
                }
            }
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dincersipka");
        }
    }
}
