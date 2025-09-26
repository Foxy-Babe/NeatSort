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

namespace NeatSort.Forms
{
    public partial class Main : Form
    {
        public MainForm _mainForm; // Declare an instance of MainForm
        private bool sidebarExpanded = true;
        private int sidebarMinWidth = 55;
        private int sidebarMaxWidth = 192; // Initial max width of the sidebar

        private Image _hideSidebarImage;
        private Image _showSidebarImage;

        private Image _hideSidebarImageLightMode;
        private Image _showSidebarImageLightMode;
        private Image _settingsImageLightMode;
        private Image _sortImageLightMode;
        private Image _LogoLightMode;

        // Add these fields to store dark mode images
        private Image _hideSidebarImageDarkMode;
        private Image _showSidebarImageDarkMode;
        private Image _settingsImageDarkMode;
        private Image _sortImageDarkMode;
        private Image _LogoDarkMode;

        public Main()
        {
            InitializeComponent();
            // Initialize LIGHT mode images from application resources
            _hideSidebarImageLightMode = NeatSort.Properties.Resources.hide;
            _showSidebarImageLightMode = NeatSort.Properties.Resources.show;
            _settingsImageLightMode = NeatSort.Properties.Resources.settings;
            _sortImageLightMode = NeatSort.Properties.Resources.sort;
            _LogoLightMode = NeatSort.Properties.Resources.Nee; // Assuming you have a light mode logo resource

            // Initialize DARK mode images from application resources
            _hideSidebarImageDarkMode = NeatSort.Properties.Resources.hidde;
            _showSidebarImageDarkMode = NeatSort.Properties.Resources.shwn;
            _settingsImageDarkMode = NeatSort.Properties.Resources.sttn;
            _sortImageDarkMode = NeatSort.Properties.Resources.srtt;
            _LogoDarkMode = NeatSort.Properties.Resources.Neat; // Assuming you have a dark mode logo resource

            _hideSidebarImage = NeatSort.Properties.Resources.hide; // Assuming you have an image resource for hiding sidebar
            _showSidebarImage = NeatSort.Properties.Resources.show;
            UpdateSidebarButtonAppearance();

            this.SuspendLayout();
            // Your initialization code
            this.ResumeLayout(false);
        }

        private void UpdateSidebarButtonAppearance()
        {
            if (btnsidebar == null) return;

            if (sidebarExpanded)
            {
                if (_hideSidebarImage != null) btnsidebar.Image = _hideSidebarImage;
                else btnsidebar.Text = "<";
            }
            else
            {
                if (_showSidebarImage != null) btnsidebar.Image = _showSidebarImage;
                else btnsidebar.Text = ">";
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ApplyTheme(Properties.Settings.Default.DarkMode);
            settingsForm.FormClosed += (s, args) =>
            {
                ApplyTheme(Properties.Settings.Default.DarkMode);
                if (_mainForm != null)
                {
                    _mainForm.ApplyTheme(Properties.Settings.Default.DarkMode);
                    _mainForm.RefreshSettings();
                    _mainForm.UpdateTimersFromSettings();
                    _mainForm.UpdateAutoSortState();
                }
                LoadFormIntoPanel(_mainForm);
            };
            LoadFormIntoPanel(settingsForm);
        }

        private void LoadFormIntoPanel(Form form)
        {
            panelShow.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            panelShow.Controls.Add(form);
            form.Show();
            CenterFormInPanel(form, panelShow); // Center the loaded form
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _mainForm = new MainForm(); // Initialize the MainForm instance
            LoadFormIntoPanel(_mainForm); // Show file organizer on launch
            ApplyTheme(Properties.Settings.Default.DarkMode); // Apply theme on load
            sidebarMaxWidth = panelSidebar.Width; // Capture the initial max width of the sidebar
        }

        // New method to apply theme to the Main form and its controls
        public void ApplyTheme(bool darkMode)
        {
            ThemeManager.ApplyTheme(this, darkMode);

            if (darkMode)
            {
                _hideSidebarImage = _hideSidebarImageDarkMode;
                _showSidebarImage = _showSidebarImageDarkMode;
                btnSettings.Image = _settingsImageDarkMode;
                btnSort.Image = _sortImageDarkMode;
                pictureBoxLogo.Image = _LogoDarkMode; // Set dark mode logo
            }
            else
            {
                _hideSidebarImage = _hideSidebarImageLightMode;
                _showSidebarImage = _showSidebarImageLightMode;
                btnSettings.Image = _settingsImageLightMode;
                btnSort.Image = _sortImageLightMode;
                pictureBoxLogo.Image = _LogoLightMode; // Set light mode logo
            }
            UpdateSidebarButtonAppearance();
            this.Refresh(); // Force repaint
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(_mainForm);

        }

        private void btnsidebar_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            int step = 10; // Animation speed (pixels per tick)
            if (sidebarExpanded)
            {
                // Collapse sidebar
                if (panelSidebar.Width > sidebarMinWidth)
                {
                    panelSidebar.Width -= step;
                    // Fade out logo as sidebar shrinks
                    if (panelSidebar.Width < 138 / 2 && pictureBoxLogo.Visible)
                    {
                        pictureBoxLogo.Visible = false;
                    }
                }
                else
                {
                    sidebarExpanded = false;
                    timerSidebar.Stop();
                    UpdateSidebarButtonAppearance();
                }
            }
            else
            {
                // Expand sidebar
                if (panelSidebar.Width < 138)
                {
                    panelSidebar.Width += step;
                    // Fade in logo as sidebar expands
                    if (panelSidebar.Width > 138 / 2 && !pictureBoxLogo.Visible)
                    {
                        pictureBoxLogo.Visible = true;
                    }
                }
                else
                {
                    sidebarExpanded = true;
                    timerSidebar.Stop();
                    UpdateSidebarButtonAppearance();
                }
            }
            btnsidebar.Left = panelSidebar.Width - btnsidebar.Width - 12;
            // After sidebar animation, recenter the currently displayed form
            if (panelShow.Controls.Count > 0)
            {
                CenterFormInPanel((Form)panelShow.Controls[0], panelShow);
            }
            // Optional: Add a slight shadow effect for coolness
            panelSidebar.Invalidate();
        }

        // New method to center a form within a panel
        private void CenterFormInPanel(Form formToCenter, Panel parentPanel)
        {
            if (formToCenter == null || parentPanel == null) return;

            // Calculate the new X position to center the form horizontally
            int x = (parentPanel.Width - formToCenter.Width) / 2;
            // Calculate the new Y position to center the form vertically
            int y = (parentPanel.Height - formToCenter.Height) / 2;

            formToCenter.Location = new Point(x, y);
        }

        // Override OnResize to recenter the form when panelShow resizes (due to main form resize or sidebar collapse/expand)
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (panelShow.Controls.Count > 0)
            {
                CenterFormInPanel((Form)panelShow.Controls[0], panelShow);
            }
        }
    }
}
