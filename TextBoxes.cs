using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Files
{
    public partial class Form1 : Form
    {
        private void SaveFileBox_TextChanged(object sender, EventArgs e)
        {
            SaveFileBox.Text = SaveFileBox.Text.Trim('"');//Delete all quetes, when text_Box will receive direct path from user
        }

        private void BackupFileBox_TextChanged(object sender, EventArgs e)
        {
            BackupFileBox.Text = BackupFileBox.Text.Trim('"');
        }

        private void BackupFileAutoBox_TextChanged(object sender, EventArgs e)
        {
            BackupFileBox.Text = BackupFileBox.Text.Trim('"');
        }

        private void TimerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsLetter(number) || Char.IsWhiteSpace(number) || Char.IsPunctuation(number) || Char.IsSeparator(number))// forbiden for entering for letters and simbols 
            {
                e.Handled = true;
                return;
            }

        }
        private void TimerBox_TextChanged(object sender, EventArgs e)
        {
            char[] cArray = TimerBox.Text.ToCharArray();

            bool isSafeToConvert = true;

            for (int i = 0; i < cArray.Length; i++)
            {
                if (Char.IsLetter(cArray[i]) || Char.IsPunctuation(cArray[i]) || Char.IsSeparator(cArray[i]) || Char.IsWhiteSpace(cArray[i]))
                {
                    TimerBox.Text = "";
                    isSafeToConvert = false;
                }
            }

            if (isSafeToConvert == true)
            {
                NotifLabel.Text = "";
                int a = 0;
                int.TryParse(TimerBox.Text, out a);
                if (a < 1 || a > 999)
                {
                    NotifLabel.Text = "Your number must be from 1 to 999, please try again! Uncheck 'Autosave' for disable timer.";
                }
            }
        }
    }
}