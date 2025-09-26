namespace NeatSort.Forms
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
            this.components = new System.ComponentModel.Container();
            this.btnOrganize = new System.Windows.Forms.Button();
            this.chkCopyInstead = new System.Windows.Forms.CheckBox();
            this.chkByDate = new System.Windows.Forms.CheckBox();
            this.chkByType = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.lblAutoSortStatus = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.toltip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrganize
            // 
            this.btnOrganize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganize.Location = new System.Drawing.Point(244, 248);
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(158, 36);
            this.btnOrganize.TabIndex = 15;
            this.btnOrganize.Text = "Run Organizer";
            this.btnOrganize.UseVisualStyleBackColor = true;
            this.btnOrganize.Click += new System.EventHandler(this.btnOrganize_Click);
            // 
            // chkCopyInstead
            // 
            this.chkCopyInstead.AutoSize = true;
            this.chkCopyInstead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCopyInstead.Location = new System.Drawing.Point(244, 213);
            this.chkCopyInstead.Name = "chkCopyInstead";
            this.chkCopyInstead.Size = new System.Drawing.Size(265, 28);
            this.chkCopyInstead.TabIndex = 13;
            this.chkCopyInstead.Text = "Copy files instead of moving";
            this.chkCopyInstead.UseVisualStyleBackColor = true;
            this.chkCopyInstead.CheckedChanged += new System.EventHandler(this.chkCopyInstead_CheckedChanged);
            // 
            // chkByDate
            // 
            this.chkByDate.AutoSize = true;
            this.chkByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByDate.Location = new System.Drawing.Point(244, 179);
            this.chkByDate.Name = "chkByDate";
            this.chkByDate.Size = new System.Drawing.Size(292, 28);
            this.chkByDate.TabIndex = 12;
            this.chkByDate.Text = "Organize by Date (Month-Year)";
            this.chkByDate.UseVisualStyleBackColor = true;
            this.chkByDate.CheckedChanged += new System.EventHandler(this.chkByDate_CheckedChanged);
            // 
            // chkByType
            // 
            this.chkByType.AutoSize = true;
            this.chkByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByType.Location = new System.Drawing.Point(244, 145);
            this.chkByType.Name = "chkByType";
            this.chkByType.Size = new System.Drawing.Size(218, 28);
            this.chkByType.TabIndex = 11;
            this.chkByType.Text = "Organize by File Type";
            this.chkByType.UseVisualStyleBackColor = true;
            this.chkByType.CheckedChanged += new System.EventHandler(this.chkByType_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(244, 106);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(158, 33);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderPath.Location = new System.Drawing.Point(244, 76);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(652, 22);
            this.txtFolderPath.TabIndex = 9;
            this.txtFolderPath.TextChanged += new System.EventHandler(this.txtFolderPath_TextChanged);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(12, 78);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(205, 20);
            this.lblFolder.TabIndex = 8;
            this.lblFolder.Text = "Select Folder to Organize:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Neat File Sorter";
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Location = new System.Drawing.Point(408, 248);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(488, 258);
            this.txtLog.TabIndex = 18;
            this.txtLog.Text = "";
            // 
            // lblAutoSortStatus
            // 
            this.lblAutoSortStatus.AutoSize = true;
            this.lblAutoSortStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAutoSortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoSortStatus.Location = new System.Drawing.Point(12, 482);
            this.lblAutoSortStatus.Name = "lblAutoSortStatus";
            this.lblAutoSortStatus.Size = new System.Drawing.Size(112, 20);
            this.lblAutoSortStatus.TabIndex = 19;
            this.lblAutoSortStatus.Text = "Auto Sort: Off";
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clear Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAutoSortStatus);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrganize);
            this.Controls.Add(this.chkCopyInstead);
            this.Controls.Add(this.chkByDate);
            this.Controls.Add(this.chkByType);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.lblFolder);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.CheckBox chkCopyInstead;
        private System.Windows.Forms.CheckBox chkByDate;
        private System.Windows.Forms.CheckBox chkByType;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label lblAutoSortStatus;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ToolTip toltip;
        private System.Windows.Forms.Button button1;
    }
}