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
    public partial class EditDataEntry : Form
    {
        private User user;
        public EditDataEntry(User user)
        {
            this.user = user;
            InitializeComponent();
            using (StreamReader sr = new StreamReader(FilePath.GetFilePathTxt()))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    PasswordCreating data = new PasswordCreating(words[0], words[1], words[2], words[3]);
                        string[] row = { words[0], words[1], words[2], words[3] };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    user.info.Add(data);
                }
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            PasswordCreating match = user.info.Find(x => x.GetName() == PasswordSearchTexBox.Text);
            match.SetPassword(AES.Encrypt(NewPasswordTextBox.Text));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.info.Find(x => x.GetName() == PasswordSearchTexBox.Text)!=null)
                {
                    PasswordCreating match = user.info.Find(x => x.GetName() == PasswordSearchTexBox.Text);
                    FoundPasswordLabel.Text = match.GetPassword(); 
                }
                else
                {
                    MessageBox.Show("Nerasta jokių įrašų");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CopyTextButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FoundPasswordLabel.Text);
        }

        private void DecryptPassword_Click(object sender, EventArgs e)
        {
            FoundPasswordLabel.Text = AES.Decrypt(FoundPasswordLabel.Text);
        }

        private void DeleteDataEntryButton_Click(object sender, EventArgs e)
        {
            user.info.RemoveAt(user.info.FindIndex(x => x.GetName() == PasswordSearchTexBox.Text));
            this.Close();
       }

        private void EditDataEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            string firstLine;
            using (StreamReader sr = new StreamReader(FilePath.GetFilePathTxt()))
            {
                firstLine = sr.ReadLine();
            }
            File.Delete(FilePath.GetFilePathTxt());
            using (StreamWriter sw = new StreamWriter(FilePath.GetFilePathTxt(), true))
            {
                sw.WriteLine(firstLine);
                foreach(PasswordCreating d in user.info)
                {
                    sw.WriteLine(d.GetName() + ";" + d.GetPassword() + ";" + d.GetUrl() + ";" + d.GetComment() + ";");
                }
            }
            user.info.Clear();
        }
    }
}
