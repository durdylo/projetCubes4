﻿namespace WindowsFormsApp1
{
    partial class FormApplication
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesSitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesSitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesUtilsateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sitesToolStripMenuItem,
            this.utilisateursToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesSitesToolStripMenuItem,
            this.voirLesSitesToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sitesToolStripMenuItem.Text = "Sites";
            this.sitesToolStripMenuItem.Click += new System.EventHandler(this.sitesToolStripMenuItem_Click);
            // 
            // gérerLesSitesToolStripMenuItem
            // 
            this.gérerLesSitesToolStripMenuItem.Name = "gérerLesSitesToolStripMenuItem";
            this.gérerLesSitesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gérerLesSitesToolStripMenuItem.Text = "Gérer les sites";
            this.gérerLesSitesToolStripMenuItem.Click += new System.EventHandler(this.gérerLesSitesToolStripMenuItem_Click);
            // 
            // voirLesSitesToolStripMenuItem
            // 
            this.voirLesSitesToolStripMenuItem.Name = "voirLesSitesToolStripMenuItem";
            this.voirLesSitesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voirLesSitesToolStripMenuItem.Text = "Voir les sites";
            this.voirLesSitesToolStripMenuItem.Click += new System.EventHandler(this.voirLesSitesToolStripMenuItem_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesUtilsateursToolStripMenuItem,
            this.voirLesUtilisateursToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilisateursToolStripMenuItem.Text = "Salariés";
            // 
            // gérerLesUtilsateursToolStripMenuItem
            // 
            this.gérerLesUtilsateursToolStripMenuItem.Name = "gérerLesUtilsateursToolStripMenuItem";
            this.gérerLesUtilsateursToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.gérerLesUtilsateursToolStripMenuItem.Text = "Gérer les salariés";
            this.gérerLesUtilsateursToolStripMenuItem.Click += new System.EventHandler(this.gérerLesUtilsateursToolStripMenuItem_Click);
            // 
            // voirLesUtilisateursToolStripMenuItem
            // 
            this.voirLesUtilisateursToolStripMenuItem.Name = "voirLesUtilisateursToolStripMenuItem";
            this.voirLesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.voirLesUtilisateursToolStripMenuItem.Text = "Voir les salariés";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererLesServicesToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // gererLesServicesToolStripMenuItem
            // 
            this.gererLesServicesToolStripMenuItem.Name = "gererLesServicesToolStripMenuItem";
            this.gererLesServicesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gererLesServicesToolStripMenuItem.Text = "Gerer les services";
            this.gererLesServicesToolStripMenuItem.Click += new System.EventHandler(this.gererLesServicesToolStripMenuItem_Click);
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormApplication";
            this.Text = "FormApplication";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesSitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesSitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesUtilsateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesServicesToolStripMenuItem;
    }
}