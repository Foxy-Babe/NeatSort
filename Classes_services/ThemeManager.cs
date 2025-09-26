using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeatSort.Classes_services
{
    public static class ThemeManager
    {

        public static void ApplyTheme(Control control, bool darkMode)
        {
            if (darkMode)
            {
                ApplyDarkMode(control);
            }
            else
            {
                ApplyLightMode(control);
            }
        }


        private static void ApplyDarkMode(Control control)
        {
            // Base colors for dark mode
            Color backColor = Color.FromArgb(45, 45, 48); // Main form/control background
            Color foreColor = Color.White; // Text color
            Color controlDark = Color.FromArgb(30, 30, 30); // Buttons and other controls
            Color panelColor = Color.FromArgb(60, 60, 60); // General panel color

            // Apply to the main control
            control.BackColor = backColor;
            control.ForeColor = foreColor;

            // Special handling for different control types
            foreach (Control c in control.Controls)
            {
                if (c is Button button)
                {
                    button.BackColor = controlDark;
                    button.ForeColor = foreColor;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = Color.Gray;
                }
                else if (c is TextBox || c is RichTextBox)
                {
                    c.BackColor = controlDark;
                    c.ForeColor = foreColor;
                }
                else if (c is CheckBox || c is RadioButton)
                {
                    c.BackColor = backColor;
                    c.ForeColor = foreColor;
                }
                else if (c is Panel panel)
                {
                    // Set specific panel colors first
                    if (panel.Name == "panel1") panel.BackColor = Color.FromArgb(43, 43, 46);
                    else if (panel.Name == "panel2") panel.BackColor = Color.FromArgb(43, 43, 46);
                    else if (panel.Name == "panel3") panel.BackColor = Color.FromArgb(43, 43, 46);
                    // Handle the sidebar panel specifically with a much darker color for strong contrast
                    else if (panel.Name == "panelSidebar") panel.BackColor = Color.FromArgb(40, 40, 42); // Very dark for distinct sidebar 40, 40, 42
                    else if (panel.Name == "panelShow") panel.BackColor = Color.FromArgb(43, 43, 46);
                    else panel.BackColor = panelColor;

                    // Recursively apply to children of the panel, not the panel itself
                    foreach (Control childControl in panel.Controls)
                    {
                        ApplyDarkMode(childControl);
                    }
                }
                else if (c is Label label)
                {
                    label.BackColor = backColor; // Labels should have the form's background color
                    label.ForeColor = foreColor;
                }
                else
                {
                    // Apply base colors to other controls or containers
                    c.BackColor = backColor;
                    c.ForeColor = foreColor;
                    if (c.HasChildren) ApplyDarkMode(c);
                }
            }
        }

        private static void ApplyLightMode(Control control)
        {
            // Refined light mode colors for a cleaner, modern look
            Color backColor = Color.FromArgb(248, 248, 248); // Very light grey, almost white, for main background
            Color foreColor = Color.FromArgb(25, 25, 28);   // Soft dark grey for text
            Color buttonBackColor = Color.FromArgb(235, 235, 235); // Light grey for buttons, slightly darker than main background
            Color buttonHoverColor = Color.FromArgb(220, 220, 220); // Even lighter on hover
            Color panel1Color = Color.FromArgb(235, 235, 235); // Subtle darker panel shade 1
            Color panel2Color = Color.FromArgb(235, 235, 235); // Subtle darker panel shade 2
            Color panel3Color = Color.FromArgb(235, 235, 235); // Subtle darker panel shade 3
            Color sidebarColor = Color.FromArgb(225, 225, 225); // Distinct light grey for sidebar, a bit darker than main background

            // Reset to default colors for the main control
            control.BackColor = backColor;
            control.ForeColor = foreColor;

            // Special handling for different control types
            foreach (Control c in control.Controls)
            {
                if (c is Button button)
                {
                    button.BackColor = buttonBackColor;
                    button.ForeColor = foreColor;
                    button.FlatStyle = FlatStyle.Flat;
                    // You can add hover effects here if needed, but it requires event handling
                    // button.MouseHover += (s, e) => button.BackColor = buttonHoverColor;
                    // button.MouseLeave += (s, e) => button.BackColor = buttonBackColor;
                }
                else if (c is TextBox || c is RichTextBox)
                {
                    c.BackColor = Color.White; // Keep text boxes white for readability
                    c.ForeColor = Color.Black;
                }
                else if (c is CheckBox || c is RadioButton)
                {
                    c.BackColor = backColor; // Checkboxes and radio buttons should inherit the form's background
                    c.ForeColor = foreColor;
                }
                else if (c is Panel panel)
                {
                    // Set specific panel colors for light mode
                    if (panel.Name == "panel1") panel.BackColor = panel1Color;
                    else if (panel.Name == "panel2") panel.BackColor = panel2Color;
                    else if (panel.Name == "panel3") panel.BackColor = panel3Color;
                    // Explicitly reset the sidebar panel to its new light mode color
                    else if (panel.Name == "panelSidebar") panel.BackColor = sidebarColor;
                    else if (panel.Name == "panelShow") panel.BackColor = Color.FromArgb(235, 235, 235);
                    else panel.BackColor = backColor; // Fallback to main background for other panels
                    
                    // Recursively apply to children of the panel, not the panel itself
                    foreach (Control childControl in panel.Controls)
                    {
                        ApplyLightMode(childControl);
                    }
                }
                else if (c is Label label)
                {
                    label.BackColor = backColor; // Labels should inherit the form's background
                    label.ForeColor = foreColor;
                }
                else
                {
                    // Apply base colors to other controls or containers
                    c.BackColor = backColor;
                    c.ForeColor = foreColor;
                    if (c.HasChildren) ApplyLightMode(c);
                }
            }
        }
    }
}
