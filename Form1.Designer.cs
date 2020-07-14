namespace Backup_Files
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NotifLabel = new System.Windows.Forms.Label();
            this.BackUpButton = new System.Windows.Forms.Button();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.SaveFileBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BackupFileBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveFileButt = new System.Windows.Forms.Button();
            this.labelF7 = new System.Windows.Forms.Label();
            this.labelF8 = new System.Windows.Forms.Label();
            this.LastSaveLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimerBox = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.openSaveFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BackUpFileFoldButt = new System.Windows.Forms.Button();
            this.BackUpAutoSaveFoldButt = new System.Windows.Forms.Button();
            this.BackUpAutoSaveButt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BackupFileAutoBox = new System.Windows.Forms.TextBox();
            this.TimerCheck = new System.Windows.Forms.CheckBox();
            this.folderBrowserBackupDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openBackupFileAutoDialog = new System.Windows.Forms.OpenFileDialog();
            this.openBackupFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileBackUpButt = new System.Windows.Forms.Button();
            this.ResAutoSavBut = new System.Windows.Forms.Button();
            this.labelF9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NotifLabel
            // 
            this.NotifLabel.AutoEllipsis = true;
            this.NotifLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifLabel.Location = new System.Drawing.Point(294, 246);
            this.NotifLabel.Name = "NotifLabel";
            this.NotifLabel.Size = new System.Drawing.Size(423, 72);
            this.NotifLabel.TabIndex = 0;
            this.NotifLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackUpButton
            // 
            this.BackUpButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackUpButton.Location = new System.Drawing.Point(53, 334);
            this.BackUpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackUpButton.Name = "BackUpButton";
            this.BackUpButton.Size = new System.Drawing.Size(189, 58);
            this.BackUpButton.TabIndex = 1;
            this.BackUpButton.Text = "Backup Data";
            this.BackUpButton.UseVisualStyleBackColor = true;
            this.BackUpButton.Click += new System.EventHandler(this.BackUpButton_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreButton.Location = new System.Drawing.Point(727, 333);
            this.RestoreButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(188, 58);
            this.RestoreButton.TabIndex = 2;
            this.RestoreButton.Text = "Restore Data";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // SaveFileBox
            // 
            this.SaveFileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFileBox.Location = new System.Drawing.Point(53, 53);
            this.SaveFileBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveFileBox.Multiline = true;
            this.SaveFileBox.Name = "SaveFileBox";
            this.SaveFileBox.Size = new System.Drawing.Size(664, 29);
            this.SaveFileBox.TabIndex = 3;
            this.SaveFileBox.TextChanged += new System.EventHandler(this.SaveFileBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Save File Folder:";
            // 
            // BackupFileBox
            // 
            this.BackupFileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackupFileBox.Location = new System.Drawing.Point(53, 128);
            this.BackupFileBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackupFileBox.Multiline = true;
            this.BackupFileBox.Name = "BackupFileBox";
            this.BackupFileBox.Size = new System.Drawing.Size(664, 31);
            this.BackupFileBox.TabIndex = 7;
            this.BackupFileBox.TextChanged += new System.EventHandler(this.BackupFileBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Backup File Folder:";
            // 
            // SaveFileButt
            // 
            this.SaveFileButt.Location = new System.Drawing.Point(727, 53);
            this.SaveFileButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveFileButt.Name = "SaveFileButt";
            this.SaveFileButt.Size = new System.Drawing.Size(184, 30);
            this.SaveFileButt.TabIndex = 9;
            this.SaveFileButt.Text = "MAIN FILE";
            this.SaveFileButt.UseVisualStyleBackColor = true;
            this.SaveFileButt.Click += new System.EventHandler(this.SaveFileButt_Click);
            // 
            // labelF7
            // 
            this.labelF7.AutoSize = true;
            this.labelF7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelF7.Location = new System.Drawing.Point(114, 393);
            this.labelF7.Name = "labelF7";
            this.labelF7.Size = new System.Drawing.Size(73, 17);
            this.labelF7.TabIndex = 11;
            this.labelF7.Text = "(press F7)";
            // 
            // labelF8
            // 
            this.labelF8.AutoSize = true;
            this.labelF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelF8.Location = new System.Drawing.Point(781, 393);
            this.labelF8.Name = "labelF8";
            this.labelF8.Size = new System.Drawing.Size(73, 17);
            this.labelF8.TabIndex = 12;
            this.labelF8.Text = "(press F8)";
            // 
            // LastSaveLabel
            // 
            this.LastSaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.LastSaveLabel.Location = new System.Drawing.Point(741, 283);
            this.LastSaveLabel.Name = "LastSaveLabel";
            this.LastSaveLabel.Size = new System.Drawing.Size(149, 20);
            this.LastSaveLabel.TabIndex = 13;
            // 
            // Timer
            // 
            this.Timer.Interval = 60000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerBox
            // 
            this.TimerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TimerBox.HideSelection = false;
            this.TimerBox.Location = new System.Drawing.Point(207, 255);
            this.TimerBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(63, 27);
            this.TimerBox.TabIndex = 14;
            this.TimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimerBox.TextChanged += new System.EventHandler(this.TimerBox_TextChanged);
            this.TimerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimerBox_KeyPress);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelay.Location = new System.Drawing.Point(51, 258);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(113, 20);
            this.labelDelay.TabIndex = 15;
            this.labelDelay.Text = "Delay (min):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(734, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Last Backup:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(199, 293);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(81, 25);
            this.ConfirmButton.TabIndex = 17;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // BackUpFileFoldButt
            // 
            this.BackUpFileFoldButt.Location = new System.Drawing.Point(823, 128);
            this.BackUpFileFoldButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackUpFileFoldButt.Name = "BackUpFileFoldButt";
            this.BackUpFileFoldButt.Size = new System.Drawing.Size(91, 31);
            this.BackUpFileFoldButt.TabIndex = 18;
            this.BackUpFileFoldButt.Text = "FOLDER";
            this.BackUpFileFoldButt.UseVisualStyleBackColor = true;
            this.BackUpFileFoldButt.Click += new System.EventHandler(this.BackUpFileFoldButt_Click);
            // 
            // BackUpAutoSaveFoldButt
            // 
            this.BackUpAutoSaveFoldButt.Location = new System.Drawing.Point(823, 203);
            this.BackUpAutoSaveFoldButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackUpAutoSaveFoldButt.Name = "BackUpAutoSaveFoldButt";
            this.BackUpAutoSaveFoldButt.Size = new System.Drawing.Size(91, 31);
            this.BackUpAutoSaveFoldButt.TabIndex = 22;
            this.BackUpAutoSaveFoldButt.Text = "FOLDER";
            this.BackUpAutoSaveFoldButt.UseVisualStyleBackColor = true;
            this.BackUpAutoSaveFoldButt.Click += new System.EventHandler(this.BackUpAutoSaveFoldButt_Click);
            // 
            // BackUpAutoSaveButt
            // 
            this.BackUpAutoSaveButt.Location = new System.Drawing.Point(727, 203);
            this.BackUpAutoSaveButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackUpAutoSaveButt.Name = "BackUpAutoSaveButt";
            this.BackUpAutoSaveButt.Size = new System.Drawing.Size(91, 31);
            this.BackUpAutoSaveButt.TabIndex = 21;
            this.BackUpAutoSaveButt.Text = "FILE";
            this.BackUpAutoSaveButt.UseVisualStyleBackColor = true;
            this.BackUpAutoSaveButt.Click += new System.EventHandler(this.BackUpAutoSaveButt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(49, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Backup File Folder (Autosave):";
            // 
            // BackupFileAutoBox
            // 
            this.BackupFileAutoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackupFileAutoBox.Location = new System.Drawing.Point(53, 203);
            this.BackupFileAutoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackupFileAutoBox.Multiline = true;
            this.BackupFileAutoBox.Name = "BackupFileAutoBox";
            this.BackupFileAutoBox.Size = new System.Drawing.Size(664, 31);
            this.BackupFileAutoBox.TabIndex = 19;
            this.BackupFileAutoBox.TextChanged += new System.EventHandler(this.BackupFileAutoBox_TextChanged);
            // 
            // TimerCheck
            // 
            this.TimerCheck.Location = new System.Drawing.Point(53, 293);
            this.TimerCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimerCheck.Name = "TimerCheck";
            this.TimerCheck.Size = new System.Drawing.Size(109, 25);
            this.TimerCheck.TabIndex = 24;
            this.TimerCheck.Text = "Autosave";
            this.TimerCheck.UseVisualStyleBackColor = true;
            this.TimerCheck.CheckedChanged += new System.EventHandler(this.TimerCheck_CheckedChanged);
            // 
            // FileBackUpButt
            // 
            this.FileBackUpButt.Location = new System.Drawing.Point(727, 128);
            this.FileBackUpButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileBackUpButt.Name = "FileBackUpButt";
            this.FileBackUpButt.Size = new System.Drawing.Size(91, 31);
            this.FileBackUpButt.TabIndex = 25;
            this.FileBackUpButt.Text = "FILE";
            this.FileBackUpButt.UseVisualStyleBackColor = true;
            this.FileBackUpButt.Click += new System.EventHandler(this.FileBackUpButt_Click);
            // 
            // ResAutoSavBut
            // 
            this.ResAutoSavBut.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResAutoSavBut.Location = new System.Drawing.Point(377, 333);
            this.ResAutoSavBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResAutoSavBut.Name = "ResAutoSavBut";
            this.ResAutoSavBut.Size = new System.Drawing.Size(188, 58);
            this.ResAutoSavBut.TabIndex = 26;
            this.ResAutoSavBut.Text = "Restore Autosave Data";
            this.ResAutoSavBut.UseVisualStyleBackColor = true;
            this.ResAutoSavBut.Click += new System.EventHandler(this.ResAutoSavBut_Click);
            // 
            // labelF9
            // 
            this.labelF9.AutoSize = true;
            this.labelF9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelF9.Location = new System.Drawing.Point(436, 393);
            this.labelF9.Name = "labelF9";
            this.labelF9.Size = new System.Drawing.Size(73, 17);
            this.labelF9.TabIndex = 27;
            this.labelF9.Text = "(press F9)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 423);
            this.Controls.Add(this.labelF9);
            this.Controls.Add(this.ResAutoSavBut);
            this.Controls.Add(this.FileBackUpButt);
            this.Controls.Add(this.TimerCheck);
            this.Controls.Add(this.BackUpAutoSaveFoldButt);
            this.Controls.Add(this.BackUpAutoSaveButt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BackupFileAutoBox);
            this.Controls.Add(this.BackUpFileFoldButt);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.LastSaveLabel);
            this.Controls.Add(this.labelF8);
            this.Controls.Add(this.labelF7);
            this.Controls.Add(this.SaveFileButt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackupFileBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveFileBox);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.BackUpButton);
            this.Controls.Add(this.NotifLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(973, 470);
            this.MinimumSize = new System.Drawing.Size(973, 470);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Files Backuper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotifLabel;
        private System.Windows.Forms.Button BackUpButton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.TextBox SaveFileBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BackupFileBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveFileButt;
        private System.Windows.Forms.Label labelF7;
        private System.Windows.Forms.Label labelF8;
        private System.Windows.Forms.Label LastSaveLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox TimerBox;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.OpenFileDialog openSaveFileDialog;
        private System.Windows.Forms.Button BackUpFileFoldButt;
        private System.Windows.Forms.Button BackUpAutoSaveFoldButt;
        private System.Windows.Forms.Button BackUpAutoSaveButt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BackupFileAutoBox;
        private System.Windows.Forms.CheckBox TimerCheck;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserBackupDialog;
        private System.Windows.Forms.OpenFileDialog openBackupFileAutoDialog;
        private System.Windows.Forms.OpenFileDialog openBackupFileDialog;
        private System.Windows.Forms.Button FileBackUpButt;
        private System.Windows.Forms.Button ResAutoSavBut;
        private System.Windows.Forms.Label labelF9;
    }
}

