using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Files
{
    public partial class Form1 : Form
    {
        void BackUpButton_Click(object sender, EventArgs e)
        {
            BackUp_data();
            localTimer = 0;
        }

        void RestoreButton_Click(object sender, EventArgs e)
        {
            Restore_data();
            localTimer = 0;
        }

        void ResAutoSavBut_Click(object sender, EventArgs e)
        {
            RestoreAutoSave_data();
            localTimer = 0;
        }

        void SaveFileButt_Click(object sender, EventArgs e)
        {
            if (File.Exists(SaveFileBox.Text))
            {
                openSaveFileDialog.FileName = Path.GetFileName(SaveFileBox.Text);
                openSaveFileDialog.InitialDirectory = Path.GetDirectoryName(SaveFileBox.Text);
            }
            if (openSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFileBox.Text = openSaveFileDialog.FileName;//choose you main file
            }
        }

        private void FileBackUpButt_Click(object sender, EventArgs e)
        {
            if (File.Exists(BackupFileBox.Text))
            {
                openBackupFileDialog.FileName = Path.GetFileName(BackupFileBox.Text);
                openBackupFileDialog.InitialDirectory = Path.GetDirectoryName(BackupFileBox.Text);
            }
            if (openBackupFileDialog.ShowDialog() == DialogResult.OK)
            {
                BackupFileBox.Text = openBackupFileDialog.FileName;//choose you main file
            }
        }

        private void BackUpFileFoldButt_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(BackupFileBox.Text))
                folderBrowserBackupDialog.SelectedPath = BackupFileBox.Text;
            if (folderBrowserBackupDialog.ShowDialog() == DialogResult.OK)
            {
                BackupFileBox.Text = folderBrowserBackupDialog.SelectedPath;
            }
        }

        private void BackUpAutoSaveButt_Click(object sender, EventArgs e)
        {
            if (File.Exists(BackupFileAutoBox.Text))
            {
                openBackupFileAutoDialog.FileName = Path.GetFileName(BackupFileAutoBox.Text);
                openBackupFileAutoDialog.InitialDirectory = Path.GetDirectoryName(BackupFileAutoBox.Text);
            }
            if (openBackupFileAutoDialog.ShowDialog() == DialogResult.OK)
            {
                BackupFileAutoBox.Text = openBackupFileAutoDialog.FileName;//choose you main file
            }
        }

        private void BackUpAutoSaveFoldButt_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(BackupFileAutoBox.Text))
                folderBrowserBackupDialog.SelectedPath = BackupFileAutoBox.Text;
            if (folderBrowserBackupDialog.ShowDialog() == DialogResult.OK)
            {
                BackupFileAutoBox.Text = folderBrowserBackupDialog.SelectedPath;//choose you main file
            }
        }
       
        private void ConfirmButton_Click(object sender, EventArgs e)//Set minutes, that you need for the timer, between copying file
        {
            int a = Convert.ToInt32(TimerBox.Text);
            if (a <= -1 || a > 200)
            {
                TimerBox.Text = "";
                NotifLabel.Text = "Enter please integer from 0 to 200";
            }
            if (TimerBox.Text != "" && Convert.ToInt32(TimerBox.Text) != 0)
            {
                min = Convert.ToInt32(TimerBox.Text);//Take value for "min" and use it for timer1_Tick
                localTimer = 0;
                Timer.Enabled = true;
                Timer.Start();
            }        
        }
    }
}