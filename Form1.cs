using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Files
{
    public partial class Form1 : Form
    {
        int min = 1; //Defaut integer for timer
        int localTimer = 0;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.F7) BackUpButton_Click(BackUpButton, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.F8) RestoreButton_Click(RestoreButton, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.F9) ResAutoSavBut_Click(ResAutoSavBut, null); };
            //Hotkeys
            if (TimerCheck.Checked == true)
                Timer.Enabled = true;
            Timer.Start();
            if (TimerCheck.Checked == false)
                Timer.Enabled = false;
            Timer.Stop();

        }

        void LoadSettings()
        {
            this.SaveFileBox.Text = Properties.Settings.Default.Title;
            this.BackupFileBox.Text = Properties.Settings.Default.Title1;
            this.TimerBox.Text = Properties.Settings.Default.Title2;
            this.BackupFileAutoBox.Text = Properties.Settings.Default.Title3;
            this.TimerCheck.Checked = Properties.Settings.Default.Title4;
            this.Location = new System.Drawing.Point(Properties.Settings.Default.X, Properties.Settings.Default.Y);

        }
        void Form1_Load_1(object sender, EventArgs e)
        {
            this.LoadSettings();
        }
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Title = this.SaveFileBox.Text;
            Properties.Settings.Default.Title1 = this.BackupFileBox.Text;
            Properties.Settings.Default.Title2 = this.TimerBox.Text;
            Properties.Settings.Default.Title3 = this.BackupFileAutoBox.Text;
            Properties.Settings.Default.Title4 = this.TimerCheck.Checked;
            Properties.Settings.Default.X = this.Location.X;
            Properties.Settings.Default.Y = this.Location.Y;
            Properties.Settings.Default.Save();
            //Save all the values of TextBoxes, and create some strings in Settings.settings
        }

        void BackUp_data()
        {
            if (!File.Exists(SaveFileBox.Text))
                MessageBox.Show("Location of 'Save File' is not correct, please try again!", "Files Backuper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Directory.Exists(BackupFileBox.Text))
                {
                    string destination = BackupFileBox.Text;
                    if (!destination.EndsWith("\\"))
                        destination += "\\";
                    destination += Path.GetFileName(SaveFileBox.Text);
                    File.Copy(SaveFileBox.Text, destination, true);
                    BackUpNotif();
                }

                else
                {
                    if (!File.Exists(BackupFileBox.Text))
                        MessageBox.Show("Location of 'Backup File Folder' is not correct, please try again!", "Files Backuper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        File.Copy(SaveFileBox.Text, BackupFileBox.Text, true);// replace original file instead older file in the BackUp directory
                        BackUpNotif();
                    }
                }
            }
        }
        void Restore_data()
        {
            if (!File.Exists(SaveFileBox.Text))
                MessageBox.Show("Location of 'Save File' is not correct, please try again!", "Files Backuper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (!File.Exists(BackupFileBox.Text))
                {
                    if (Directory.Exists(BackupFileBox.Text))
                    {
                        string source = BackupFileBox.Text;
                        if (!source.EndsWith("\\"))
                            source += "\\";
                        source += Path.GetFileName(SaveFileBox.Text);
                        File.Copy(source, SaveFileBox.Text, true);
                        RestoreNotif();
                    }
                }
                else
                {
                    if (!File.Exists(BackupFileBox.Text))
                        MessageBox.Show("Location of 'Backup File Folder' is not correct, please try again!", "Files Backuper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        File.Copy(BackupFileBox.Text, SaveFileBox.Text, true);
                        RestoreNotif();
                    }
                }
            }
        }

        void AutoBackUp_data()
        {
            if (!File.Exists(SaveFileBox.Text))
                MessageBox.Show("Location of 'Save File' is not correct, please try again!", "Files Backuper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Directory.Exists(BackupFileAutoBox.Text))
                {
                    string destination = BackupFileAutoBox.Text;
                    if (!destination.EndsWith("\\"))
                        destination += "\\";
                    destination += Path.GetFileName(SaveFileBox.Text);
                    File.Copy(SaveFileBox.Text, destination, true);
                    BackUpNotif();
                }

                else
                {
                    if (!File.Exists(BackupFileAutoBox.Text))
                        MessageBox.Show("Location of 'Backup File Folder (Autosave)' is not correct, please try again!", "Files Backuper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        File.Copy(SaveFileBox.Text, BackupFileAutoBox.Text, true);// replace original file instead older file in the BackUp directory
                        BackUpNotif();
                    }
                }
            }
        }

        void RestoreAutoSave_data()
        {
            Again:
            try
            {
                if (!File.Exists(SaveFileBox.Text))
                    MessageBox.Show("Location of 'Save File' is not correct, please try again!", "Files Backuper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (File.Exists(SaveFileBox.Text))
                {
                    if (!File.Exists(BackupFileAutoBox.Text))
                    {
                        if (Directory.Exists(BackupFileAutoBox.Text))
                        {
                            string source = BackupFileAutoBox.Text;
                            if (!source.EndsWith("\\"))
                                source += "\\";
                            source += Path.GetFileName(SaveFileBox.Text);
                            File.Copy(source, SaveFileBox.Text, true);
                            RestoreNotif();
                        }
                    }
                    else
                    {
                        if (!File.Exists(BackupFileAutoBox.Text))
                            MessageBox.Show("Location of 'Backup File Folder (Autosave)' is not correct, please try again!", "Files Backuper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            File.Copy(BackupFileAutoBox.Text, SaveFileBox.Text, true);
                            RestoreNotif();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                goto Again;
            }
            finally 
            {
                throw new NotImplementedException();
            }
        }
        async void BackUpNotif()
        {
            NotifLabel.Text = "Data was successfully copied!";
            await Task.Delay(3000);
            NotifLabel.Text = "";
        }

        async void RestoreNotif()
        {
            NotifLabel.Text = "Data was successfully restored!";
            await Task.Delay(3000);
            NotifLabel.Text = "";
        }

        public void Timer_Tick(object sender, EventArgs e)//timer for automatical autosaving file
        {
            if (SaveFileBox.Text != "" && BackupFileBox.Text != "")
            {
                localTimer++;
                if (localTimer >= min)
                {
                    localTimer = 0;
                    AutoBackUp_data();
                    LastSaveLabel.Text = string.Format(DateTime.Now.ToString("HH:mm:ss"));//Taking value of time of last autosaving 
                }
            }
        }

        async private void TimerCheck_CheckedChanged(object sender, EventArgs e)//Add labelnotif if Timer have not parameter in minutes
        {
            if (TimerCheck.Checked == true)
            {
                Timer.Enabled = true;
                Timer.Start();
                NotifLabel.Text = "Autosave mode - active";
                await Task.Delay(3000);
                NotifLabel.Text = "";
            }
            if (TimerCheck.Checked == false)
            {
                Timer.Enabled = false;
                Timer.Stop();
                NotifLabel.Text = "Autosave mode - deactive";
                await Task.Delay(3000);
                NotifLabel.Text = "";
            }
        }
    }
}