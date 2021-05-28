using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace IS_Pd4
{
    public partial class LoggedIn : Form
    {
        private User user;
        public LoggedIn(User user)
        {
            this.user = user;

            InitializeComponent();

            userLabel.Text = user.GetUsername();
        }

        private void addPasswordButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(FilePath.GetFilePathTxt(), true))
            {
                sw.WriteLine(nameTextBox.Text + ";" + AES.Encrypt(passwordTextBox.Text) + ";" + urlTextBox.Text + ";" + commentTextBox.Text);
            }
            MessageBox.Show("Slaptažodis pridėtas");
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator randomNumberGenerator = RNGCryptoServiceProvider.Create();
            byte[] data = new byte[128];
            randomNumberGenerator.GetBytes(data);
            passwordTextBox.Text = Convert.ToBase64String(data);
        }
        private void LoggedIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            AesFileEncryption.AesFileEncrypt(FilePath.GetFilePathTxt());
        }
        private void ManagePasswordsButton_Click(object sender, EventArgs e)
        {
            var next = new EditDataEntry(user);
            next.ShowDialog();
        }
    }
}
