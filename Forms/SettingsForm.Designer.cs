namespace NeatSort.Forms
{
    partial class SettingsForm
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
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.numAutoSortMinutes = new System.Windows.Forms.NumericUpDown();
            this.Auto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDefaultToCopy = new System.Windows.Forms.CheckBox();
            this.chkRememberDate = new System.Windows.Forms.CheckBox();
            this.chkRememberType = new System.Windows.Forms.CheckBox();
            this.btnBrowseDefault = new System.Windows.Forms.Button();
            this.txtDefaultFolder = new System.Windows.Forms.TextBox();
            this.lblDefaultFolder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkEnableAutoSort = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numAutoSortMinutes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(346, 507);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(145, 38);
            this.btnSaveSettings.TabIndex = 6;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Settings";
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDarkMode.Location = new System.Drawing.Point(142, 57);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(169, 24);
            this.chkDarkMode.TabIndex = 9;
            this.chkDarkMode.Text = "Enable Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // numAutoSortMinutes
            // 
            this.numAutoSortMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAutoSortMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAutoSortMinutes.Location = new System.Drawing.Point(260, 68);
            this.numAutoSortMinutes.Name = "numAutoSortMinutes";
            this.numAutoSortMinutes.Size = new System.Drawing.Size(120, 26);
            this.numAutoSortMinutes.TabIndex = 10;
            // 
            // Auto
            // 
            this.Auto.AutoSize = true;
            this.Auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auto.Location = new System.Drawing.Point(4, 70);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(213, 20);
            this.Auto.TabIndex = 11;
            this.Auto.Text = "Auto-sort every X minutes :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.chkDefaultToCopy);
            this.panel1.Controls.Add(this.chkRememberDate);
            this.panel1.Controls.Add(this.chkRememberType);
            this.panel1.Controls.Add(this.btnBrowseDefault);
            this.panel1.Controls.Add(this.txtDefaultFolder);
            this.panel1.Controls.Add(this.lblDefaultFolder);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 178);
            this.panel1.TabIndex = 12;
            // 
            // chkDefaultToCopy
            // 
            this.chkDefaultToCopy.AutoSize = true;
            this.chkDefaultToCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefaultToCopy.Location = new System.Drawing.Point(142, 143);
            this.chkDefaultToCopy.Name = "chkDefaultToCopy";
            this.chkDefaultToCopy.Size = new System.Drawing.Size(278, 24);
            this.chkDefaultToCopy.TabIndex = 11;
            this.chkDefaultToCopy.Text = "Default to \'Copy instead of move\'";
            this.chkDefaultToCopy.UseVisualStyleBackColor = true;
            this.chkDefaultToCopy.CheckedChanged += new System.EventHandler(this.chkDefaultToCopy_CheckedChanged);
            // 
            // chkRememberDate
            // 
            this.chkRememberDate.AutoSize = true;
            this.chkRememberDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberDate.Location = new System.Drawing.Point(142, 113);
            this.chkRememberDate.Name = "chkRememberDate";
            this.chkRememberDate.Size = new System.Drawing.Size(212, 24);
            this.chkRememberDate.TabIndex = 10;
            this.chkRememberDate.Text = "Always organize by date";
            this.chkRememberDate.UseVisualStyleBackColor = true;
            this.chkRememberDate.CheckedChanged += new System.EventHandler(this.chkRememberDate_CheckedChanged);
            // 
            // chkRememberType
            // 
            this.chkRememberType.AutoSize = true;
            this.chkRememberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberType.Location = new System.Drawing.Point(142, 83);
            this.chkRememberType.Name = "chkRememberType";
            this.chkRememberType.Size = new System.Drawing.Size(238, 24);
            this.chkRememberType.TabIndex = 9;
            this.chkRememberType.Text = "Always organize by file type";
            this.chkRememberType.UseVisualStyleBackColor = true;
            this.chkRememberType.CheckedChanged += new System.EventHandler(this.chkRememberType_CheckedChanged);
            // 
            // btnBrowseDefault
            // 
            this.btnBrowseDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDefault.Location = new System.Drawing.Point(142, 46);
            this.btnBrowseDefault.Name = "btnBrowseDefault";
            this.btnBrowseDefault.Size = new System.Drawing.Size(118, 31);
            this.btnBrowseDefault.TabIndex = 8;
            this.btnBrowseDefault.Text = "Browse...";
            this.btnBrowseDefault.UseVisualStyleBackColor = true;
            this.btnBrowseDefault.Click += new System.EventHandler(this.btnBrowseDefault_Click);
            // 
            // txtDefaultFolder
            // 
            this.txtDefaultFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDefaultFolder.Location = new System.Drawing.Point(142, 18);
            this.txtDefaultFolder.Name = "txtDefaultFolder";
            this.txtDefaultFolder.Size = new System.Drawing.Size(650, 22);
            this.txtDefaultFolder.TabIndex = 7;
            // 
            // lblDefaultFolder
            // 
            this.lblDefaultFolder.AutoSize = true;
            this.lblDefaultFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDefaultFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultFolder.Location = new System.Drawing.Point(3, 20);
            this.lblDefaultFolder.Name = "lblDefaultFolder";
            this.lblDefaultFolder.Size = new System.Drawing.Size(125, 20);
            this.lblDefaultFolder.TabIndex = 6;
            this.lblDefaultFolder.Text = "Default Folder :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chkDarkMode);
            this.panel2.Location = new System.Drawing.Point(12, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 124);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dark Mode";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.chkEnableAutoSort);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Auto);
            this.panel3.Controls.Add(this.numAutoSortMinutes);
            this.panel3.Location = new System.Drawing.Point(12, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(886, 141);
            this.panel3.TabIndex = 14;
            // 
            // chkEnableAutoSort
            // 
            this.chkEnableAutoSort.AutoSize = true;
            this.chkEnableAutoSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableAutoSort.Location = new System.Drawing.Point(259, 105);
            this.chkEnableAutoSort.Name = "chkEnableAutoSort";
            this.chkEnableAutoSort.Size = new System.Drawing.Size(179, 24);
            this.chkEnableAutoSort.TabIndex = 12;
            this.chkEnableAutoSort.Text = "Enable Auto Sorting";
            this.chkEnableAutoSort.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Auto Sort";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAutoSortMinutes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.NumericUpDown numAutoSortMinutes;
        private System.Windows.Forms.Label Auto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkDefaultToCopy;
        private System.Windows.Forms.CheckBox chkRememberDate;
        private System.Windows.Forms.CheckBox chkRememberType;
        private System.Windows.Forms.Button btnBrowseDefault;
        private System.Windows.Forms.TextBox txtDefaultFolder;
        private System.Windows.Forms.Label lblDefaultFolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEnableAutoSort;
        private System.Windows.Forms.ToolTip toolTip;
    }
}