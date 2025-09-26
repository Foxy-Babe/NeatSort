using NeatSort.Classes_services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NeatSort.Forms
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnBrowseDefault_Click(object sender, EventArgs e)
        {

            if (folderBrowserDlg.ShowDialog() == DialogResult.OK)
            {
                txtDefaultFolder.Text = folderBrowserDlg.SelectedPath;
            }

        }


        private void btnSaveSettings_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.DefaultFolder = txtDefaultFolder.Text;
            Properties.Settings.Default.OrganizeByType = chkRememberType.Checked;
            Properties.Settings.Default.OrganizeByDate = chkRememberDate.Checked;
            Properties.Settings.Default.DefaultToCopy = chkDefaultToCopy.Checked;
            Properties.Settings.Default.AutoSortEnabled = chkEnableAutoSort.Checked;
            Properties.Settings.Default.AutoSortIntervalMinutes = (int)numAutoSortMinutes.Value;
            Properties.Settings.Default.DarkMode = chkDarkMode.Checked;
            Properties.Settings.Default.Save();

            SettingsChanged = true; // ✅ mark as changed

            // Apply theme AFTER saving settings and BEFORE showing the message box
            ApplyTheme(Properties.Settings.Default.DarkMode);

            // Update all open forms - combined approach
            var mainAppForm = Application.OpenForms.OfType<Main>().FirstOrDefault();
            var mainFormInstance = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            // Update Main application form (container)
            if (mainAppForm != null)
            {
                mainAppForm.ApplyTheme(Properties.Settings.Default.DarkMode);

                // If the Main form has a MainForm instance, update it too
                if (mainAppForm._mainForm != null)
                {
                    mainAppForm._mainForm.ApplyTheme(Properties.Settings.Default.DarkMode);
                    mainAppForm._mainForm.RefreshSettings();
                    mainAppForm._mainForm.UpdateTimersFromSettings();
                    mainAppForm._mainForm.UpdateAutoSortState();
                }
            }

            // Update standalone MainForm if it exists (though in your architecture it probably doesn't)
            if (mainFormInstance != null && (mainAppForm == null || mainAppForm._mainForm != mainFormInstance))
            {
                mainFormInstance.ApplyTheme(Properties.Settings.Default.DarkMode);
                mainFormInstance.RefreshSettings();
                mainFormInstance.UpdateTimersFromSettings();
                mainFormInstance.UpdateAutoSortState();
            }

            MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public string DefaultFolder { get; private set; }
        public bool OrganizeByType { get; private set; }
        public bool OrganizeByDate { get; private set; }
        public bool DefaultToCopy { get; private set; }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            txtDefaultFolder.Text = Properties.Settings.Default.DefaultFolder;
            chkRememberType.Checked = Properties.Settings.Default.OrganizeByType;
            chkRememberDate.Checked = Properties.Settings.Default.OrganizeByDate;
            chkDefaultToCopy.Checked = Properties.Settings.Default.DefaultToCopy;
            chkEnableAutoSort.Checked = Properties.Settings.Default.AutoSortEnabled;
            numAutoSortMinutes.Value = Properties.Settings.Default.AutoSortIntervalMinutes;
            chkDarkMode.Checked = Properties.Settings.Default.DarkMode;

            // Apply theme on load so the initial state is correct
            //ApplyTheme(Properties.Settings.Default.DarkMode);
            chkDefaultToCopy.Enabled = chkRememberType.Checked || chkRememberDate.Checked;
            toolTip.SetToolTip(chkDefaultToCopy,
                    "Requires 'By Type' or 'By Date' to be selected.\n" +
                    "When checked, files will be copied instead of moved.");
        }
        public void ApplyTheme(bool darkMode)
        {
            ThemeManager.ApplyTheme(this, darkMode);

            // Special handling for panels in light mode
            if (!darkMode)
            {
                Color panel1Color = Color.FromArgb(235, 235, 235); // Subtle darker panel shade 1
                Color panel2Color = Color.FromArgb(235, 235, 235); // Subtle darker panel shade 2
                Color panel3Color = Color.FromArgb(235, 235, 235); // Subtle darker panel shade 3
            }
            else
            {
                // Ensure panels have dark mode colors when applying theme for real
                panel1.BackColor = Color.FromArgb(43, 43, 46);
                panel2.BackColor = Color.FromArgb(43, 43, 46);
                panel3.BackColor = Color.FromArgb(43, 43, 46);
            }

            this.Refresh();
        }

        public bool SettingsChanged { get; private set; } = false;

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {

            

        }

        private void chkRememberType_CheckedChanged(object sender, EventArgs e)
        {
            chkDefaultToCopy.Enabled = chkRememberType.Checked || chkRememberDate.Checked;
        }

        private void chkRememberDate_CheckedChanged(object sender, EventArgs e)
        {
            chkDefaultToCopy.Enabled = chkRememberType.Checked || chkRememberDate.Checked;
        }

        private void chkDefaultToCopy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
