namespace NeatSort.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.btnsidebar = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Gray;
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.btnsidebar);
            this.panelSidebar.Controls.Add(this.pictureBoxLogo);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnSort);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(192, 552);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelShow
            // 
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(192, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(914, 552);
            this.panelShow.TabIndex = 1;
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 10;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // btnsidebar
            // 
            this.btnsidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsidebar.Image = global::NeatSort.Properties.Resources.hide;
            this.btnsidebar.Location = new System.Drawing.Point(137, 3);
            this.btnsidebar.Name = "btnsidebar";
            this.btnsidebar.Size = new System.Drawing.Size(49, 49);
            this.btnsidebar.TabIndex = 3;
            this.btnsidebar.UseVisualStyleBackColor = true;
            this.btnsidebar.Click += new System.EventHandler(this.btnsidebar_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::NeatSort.Properties.Resources.Nee;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, 381);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(192, 170);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::NeatSort.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(6, 129);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(180, 54);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSort
            // 
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Image = global::NeatSort.Properties.Resources.sort;
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSort.Location = new System.Drawing.Point(6, 69);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(179, 54);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort Files";
            this.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 552);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEAT FILE SORTER";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Button btnsidebar;
        private System.Windows.Forms.Timer timerSidebar;
    }
}