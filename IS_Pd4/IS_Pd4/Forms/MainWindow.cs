using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Pd4
{
    public partial class MainWindow : Form
    {
        private User user = new User();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] fileEntries = Directory.GetFiles(@"C:\Users\Laurynas\Desktop\testfiles");
                foreach (string filePath in fileEntries)
                {
                    string fileName = Path.GetFileName(filePath);
                    if (fileName == usernameTextBox.Text + ".txt.aes")
                    {
                        MessageBox.Show("Toks vartotojas jau egzistuoja");
                    }
                }
                FilePath.SetFilePathTxt(String.Format(@"C:\Users\Laurynas\Desktop\testfiles\" + usernameTextBox.Text + ".txt"));
                using (StreamWriter sr = new StreamWriter(FilePath.GetFilePathTxt()))
                {
                    sr.WriteLine(passwordTextBox.Text);
                }
                AesFileEncryption.AesFileEncrypt(FilePath.GetFilePathTxt());
                MessageBox.Show("Registracija pavyko");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FilePath.SetFilePathTxt(String.Format(@"C:\Users\Laurynas\Desktop\testfiles\" + usernameTextBox.Text + ".txt"));
            try
            {
                AesFileEncryption.AesFileDecrypt(FilePath.GetFilePathTxt() + ".aes");
                string line1 = File.ReadLines(FilePath.GetFilePathTxt()).First();
                if (line1 == passwordTextBox.Text)
                {
                    this.Hide();
                    user.SetPassword(passwordTextBox.Text);
                    user.SetUsername(usernameTextBox.Text);
                    var next = new LoggedIn(user);
                    File.Delete(FilePath.GetFilePathTxt() + ".aes");
                    next.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Slaptažodžiai nesutampa");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
