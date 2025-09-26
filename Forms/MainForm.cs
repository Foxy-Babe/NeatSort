using NeatSort.Classes_services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NeatSort.Forms
{
    public partial class MainForm : Form
    {
        
        private int secondsUntilNextAutoSort = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            ApplyTheme(Properties.Settings.Default.DarkMode);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            if (folderBrowserDlg.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDlg.SelectedPath;
            }

        }

        private void OrganizeFiles(bool isAutoSort = false)
        {
            string folderPath = txtFolderPath.Text;

            if (string.IsNullOrWhiteSpace(folderPath) || !Directory.Exists(folderPath))
            {
                if (!isAutoSort)
                {
                    MessageBox.Show("Please select a valid folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            string[] files = Directory.GetFiles(folderPath, "*", SearchOption.TopDirectoryOnly);
            int processed = 0;

            foreach (var file in files)
            {
                try
                {
                    string targetSubFolder = "";
                    string fileName = Path.GetFileName(file);
                    string parentFolderName = new DirectoryInfo(Path.GetDirectoryName(file)).Name;

                    // Skip files that are already in their correct folder
                    if (chkByType.Checked)
                    {
                        string ext = Path.GetExtension(file).TrimStart('.').ToUpper();
                        if (!chkCopyInstead.Checked && parentFolderName.Equals(ext, StringComparison.OrdinalIgnoreCase))
                            continue;

                        targetSubFolder = Path.Combine(folderPath, ext);
                    }
                    else if (chkByDate.Checked)
                    {
                        var created = File.GetCreationTime(file);
                        string folderName = $"{created:yyyy-MM}";
                        if (!chkCopyInstead.Checked && parentFolderName.Equals(folderName, StringComparison.OrdinalIgnoreCase))
                            continue;

                        targetSubFolder = Path.Combine(folderPath, folderName);
                    }
                    else
                    {
                        if (!isAutoSort)
                        {
                            MessageBox.Show("Please select an organization method (by type or by date).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }

                    // Ensure the target directory exists
                    Directory.CreateDirectory(targetSubFolder);

                    string destPath = Path.Combine(targetSubFolder, fileName);

                    // Handle duplicate file names
                    if (File.Exists(destPath) && chkCopyInstead.Checked)
                    {
                        // Only create unique names for copies, not moves
                        int count = 1;
                        string nameWithoutExt = Path.GetFileNameWithoutExtension(file);
                        string ext = Path.GetExtension(file);
                        while (File.Exists(destPath))
                        {
                            destPath = Path.Combine(targetSubFolder, $"{nameWithoutExt} ({count}){ext}");
                            count++;
                        }
                    }

                    if (chkCopyInstead.Checked)
                    {
                        File.Copy(file, destPath, false); // Explicitly don't overwrite
                        txtLog.AppendText($"Copied: {fileName} to {destPath}{Environment.NewLine}");
                    }
                    else
                    {
                        // For move operations, skip if destination exists
                        if (!File.Exists(destPath))
                        {
                            File.Move(file, destPath);
                            txtLog.AppendText($"Moved: {fileName} to {destPath}{Environment.NewLine}");
                        }
                        else
                        {
                            txtLog.AppendText($"Skipped (already exists): {fileName}{Environment.NewLine}");
                            continue;
                        }
                    }

                    processed++;
                }
                catch (Exception ex)
                {
                    txtLog.AppendText($"Error processing {file}: {ex.Message}{Environment.NewLine}");
                }
            }

            if (!isAutoSort)
            {
                MessageBox.Show($"Processed {processed} files.", "Operation Complete", MessageBoxButtons.OK, processed > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            else if (processed > 0)
            {
                txtLog.AppendText($"Auto-Sort: Processed {processed} files.{Environment.NewLine}");
            }
        }


        private void btnOrganize_Click(object sender, EventArgs e)
        {

            // Add debug output to verify the click is registered
            Debug.WriteLine("Organize button clicked");
            txtLog.AppendText("Organize button clicked - starting operation...\n");

            OrganizeFiles(false);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // Load UI settings from properties once
            txtFolderPath.Text = Properties.Settings.Default.DefaultFolder;
            chkByType.Checked = Properties.Settings.Default.OrganizeByType;
            chkByDate.Checked = Properties.Settings.Default.OrganizeByDate;
            chkCopyInstead.Checked = Properties.Settings.Default.DefaultToCopy;

            chkCopyInstead.Enabled = chkByType.Checked || chkByDate.Checked;
            // Apply theme
            ApplyTheme(Properties.Settings.Default.DarkMode);
            RefreshSettings();
            // Initialize and start timers based on the loaded settings
            UpdateTimersFromSettings();
            UpdateAutoSortState();
            toltip.SetToolTip(chkCopyInstead,
                    "Requires 'By Type' or 'By Date' to be selected.\n" +
                    "When checked, files will be copied instead of moved.");

        }

        // New method to refresh all settings
        public void RefreshSettings()
        {
            txtFolderPath.Text = Properties.Settings.Default.DefaultFolder;
            chkByType.Checked = Properties.Settings.Default.OrganizeByType;
            chkByDate.Checked = Properties.Settings.Default.OrganizeByDate;
            chkCopyInstead.Checked = Properties.Settings.Default.DefaultToCopy;

            // Force update of all dependent controls
            UpdateAutoSortState();
            UpdateTimersFromSettings();

            // Refresh the UI
            this.Refresh();
        }

        public void ApplyTheme(bool darkMode)
        {
            // Apply to this form and all controls
            ThemeManager.ApplyTheme(this, darkMode);

            

            // Force a refresh
            this.Refresh();
        }



        private void mainTimer_Tick(object sender, EventArgs e)
        {
            // This is our new, single tick event.
            if (secondsUntilNextAutoSort > 0)
            {
                // If the countdown is still running, just decrement and update the label.
                secondsUntilNextAutoSort--;
                UpdateStatusLabel();
            }
            else
            {
                // When the countdown reaches zero, it's time to sort!
                mainTimer.Stop(); // Pause the timer during the sort operation.

                try
                {
                    txtLog.AppendText($"Auto-sort triggered by timer.{Environment.NewLine}");
                    OrganizeFiles(true); // Run the silent sort.
                }
                catch (Exception ex)
                {
                    txtLog.AppendText($"Auto Sort failed: {ex.Message}{Environment.NewLine}");
                }
                finally
                {
                    // IMPORTANT: Reset the countdown for the next interval and restart the timer.
                    secondsUntilNextAutoSort = Properties.Settings.Default.AutoSortIntervalMinutes * 60;
                    mainTimer.Start();
                }
            }
        }

        public void UpdateStatusLabel()
        {
            // Helper method to update the countdown label text
            TimeSpan time = TimeSpan.FromSeconds(secondsUntilNextAutoSort);
            lblAutoSortStatus.Text = $"Auto Sort: Active (Next in {time.Minutes:D2}:{time.Seconds:D2})";
        }

        // In MainForm.cs

        // In MainForm.cs

        public void UpdateTimersFromSettings()
        {
            // Stop the main timer and clear its event handler to prevent duplicates.
            mainTimer.Stop();
            mainTimer.Tick -= mainTimer_Tick;

            if (Properties.Settings.Default.AutoSortEnabled && Properties.Settings.Default.AutoSortIntervalMinutes > 0)
            {
                // Set the countdown variable from settings.
                secondsUntilNextAutoSort = Properties.Settings.Default.AutoSortIntervalMinutes * 60;

                // Configure our single timer to tick every second.
                mainTimer.Interval = 1000;
                mainTimer.Tick += mainTimer_Tick;
                mainTimer.Start();

                // Immediately update the status label so the user sees the change.
                UpdateStatusLabel();
            }
            else
            {
                lblAutoSortStatus.Text = "Auto Sort: Disabled";
            }
        }

        public void UpdateAutoSortState()
        {
            bool autoSortConfigured = Properties.Settings.Default.AutoSortEnabled &&
                                      Properties.Settings.Default.AutoSortIntervalMinutes > 0;
            bool pathIsValid = !string.IsNullOrWhiteSpace(txtFolderPath.Text) && Directory.Exists(txtFolderPath.Text);
            bool sortOptionIsSelected = chkByType.Checked || chkByDate.Checked;

            // Stop the timer and clear the handler to prevent multiple subscriptions
            mainTimer.Stop();
            mainTimer.Tick -= mainTimer_Tick;

            // The timer should only run if ALL conditions are met
            if (autoSortConfigured && pathIsValid && sortOptionIsSelected)
            {
                // Conditions met, so configure and start the timer
                secondsUntilNextAutoSort = Properties.Settings.Default.AutoSortIntervalMinutes * 60;
                mainTimer.Interval = 1000; // Tick every second
                mainTimer.Tick += mainTimer_Tick;
                mainTimer.Start();
                UpdateStatusLabel(); // Show the active countdown
            }
            else
            {
                // If any condition is not met, ensure timer is off and the status is updated
                lblAutoSortStatus.Text = "Auto Sort: Inactive";
            }
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            UpdateAutoSortState();
        }

        private void chkByType_CheckedChanged(object sender, EventArgs e)
        {
            chkCopyInstead.Enabled = chkByType.Checked || chkByDate.Checked;
            UpdateAutoSortState();
        }

        private void chkByDate_CheckedChanged(object sender, EventArgs e)
        {
            chkCopyInstead.Enabled = chkByType.Checked || chkByDate.Checked;
            UpdateAutoSortState();
        }

        private void chkCopyInstead_CheckedChanged(object sender, EventArgs e)
        {
            
            UpdateAutoSortState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var logIsEmpty = string.IsNullOrWhiteSpace(txtLog.Text);
            if (logIsEmpty)
            {
                MessageBox.Show("The log is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to clear the log?",
                "Confirm Clear Log",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtLog.Clear();
            }
        }
    }
}
