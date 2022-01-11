namespace WindowsFormsApp1.Presentation.GestionSites
{
    partial class FormGererSites
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
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.bt_precede = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.Site = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dataGridSites = new System.Windows.Forms.DataGridView();
            this.bt_new = new System.Windows.Forms.Button();
            this.bt_sup = new System.Windows.Forms.Button();
            this.Site.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSites)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(43, 55);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(26, 13);
            this.lbl_City.TabIndex = 0;
            this.lbl_City.Text = "Ville";
            this.lbl_City.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(156, 52);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 1;
            this.txt_City.TextChanged += new System.EventHandler(this.txt_City_TextChanged);
            // 
            // bt_precede
            // 
            this.bt_precede.Location = new System.Drawing.Point(0, 0);
            this.bt_precede.Name = "bt_precede";
            this.bt_precede.Size = new System.Drawing.Size(75, 23);
            this.bt_precede.TabIndex = 18;
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(0, 0);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(75, 23);
            this.bt_next.TabIndex = 17;
            // 
            // Site
            // 
            this.Site.Controls.Add(this.txt_City);
            this.Site.Controls.Add(this.lbl_City);
            this.Site.Location = new System.Drawing.Point(35, 104);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(290, 191);
            this.Site.TabIndex = 14;
            this.Site.TabStop = false;
            this.Site.Text = "Site";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(360, 366);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(10, 13);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "-";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // dataGridSites
            // 
            this.dataGridSites.AllowUserToOrderColumns = true;
            this.dataGridSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSites.Location = new System.Drawing.Point(548, 104);
            this.dataGridSites.Name = "dataGridSites";
            this.dataGridSites.ShowCellErrors = false;
            this.dataGridSites.Size = new System.Drawing.Size(466, 315);
            this.dataGridSites.TabIndex = 16;
            this.dataGridSites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSites_CellContentClick);
            this.dataGridSites.DoubleClick += new System.EventHandler(this.dataGridSites_DoubleClick);
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(346, 104);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 23);
            this.bt_new.TabIndex = 2;
            this.bt_new.Text = "Ajouter";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // bt_sup
            // 
            this.bt_sup.Location = new System.Drawing.Point(346, 252);
            this.bt_sup.Name = "bt_sup";
            this.bt_sup.Size = new System.Drawing.Size(75, 23);
            this.bt_sup.TabIndex = 19;
            this.bt_sup.Text = "Supprimer";
            this.bt_sup.UseVisualStyleBackColor = true;
            this.bt_sup.Click += new System.EventHandler(this.bt_sup_Click);
            // 
            // FormGererSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 597);
            this.Controls.Add(this.bt_sup);
            this.Controls.Add(this.dataGridSites);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.Site);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_precede);
            this.Controls.Add(this.bt_new);
            this.Name = "FormGererSites";
            this.Text = "Gérer les sites";
            this.Load += new System.EventHandler(this.FormGererSites_Load);
            this.Site.ResumeLayout(false);
            this.Site.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Button bt_precede;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.GroupBox Site;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridView dataGridSites;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Button bt_sup;
    }
}