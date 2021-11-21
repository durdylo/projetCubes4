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
            this.bt_new = new System.Windows.Forms.Button();
            this.lbl_dateCreate = new System.Windows.Forms.Label();
            this.lbl_dateModif = new System.Windows.Forms.Label();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_modif = new System.Windows.Forms.Button();
            this.bt_sup = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_precede = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_end = new System.Windows.Forms.Button();
            this.lbl_create = new System.Windows.Forms.Label();
            this.lbl_modif = new System.Windows.Forms.Label();
            this.Site = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.Site.SuspendLayout();
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
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(346, 104);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 23);
            this.bt_new.TabIndex = 2;
            this.bt_new.Text = "Nouveau";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // lbl_dateCreate
            // 
            this.lbl_dateCreate.AutoSize = true;
            this.lbl_dateCreate.Location = new System.Drawing.Point(43, 113);
            this.lbl_dateCreate.Name = "lbl_dateCreate";
            this.lbl_dateCreate.Size = new System.Drawing.Size(86, 13);
            this.lbl_dateCreate.TabIndex = 3;
            this.lbl_dateCreate.Text = "Date de création";
            // 
            // lbl_dateModif
            // 
            this.lbl_dateModif.AutoSize = true;
            this.lbl_dateModif.Location = new System.Drawing.Point(43, 149);
            this.lbl_dateModif.Name = "lbl_dateModif";
            this.lbl_dateModif.Size = new System.Drawing.Size(104, 13);
            this.lbl_dateModif.TabIndex = 4;
            this.lbl_dateModif.Text = "Date de modification";
            this.lbl_dateModif.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(346, 144);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(75, 23);
            this.bt_register.TabIndex = 5;
            this.bt_register.Text = "Enregistrer";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_modif
            // 
            this.bt_modif.Location = new System.Drawing.Point(346, 196);
            this.bt_modif.Name = "bt_modif";
            this.bt_modif.Size = new System.Drawing.Size(75, 23);
            this.bt_modif.TabIndex = 6;
            this.bt_modif.Text = "Modifier";
            this.bt_modif.UseVisualStyleBackColor = true;
            // 
            // bt_sup
            // 
            this.bt_sup.Location = new System.Drawing.Point(346, 240);
            this.bt_sup.Name = "bt_sup";
            this.bt_sup.Size = new System.Drawing.Size(75, 23);
            this.bt_sup.TabIndex = 7;
            this.bt_sup.Text = "Supprimer";
            this.bt_sup.UseVisualStyleBackColor = true;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(22, 358);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 8;
            this.bt_start.Text = "Début";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_precede
            // 
            this.bt_precede.Location = new System.Drawing.Point(103, 357);
            this.bt_precede.Name = "bt_precede";
            this.bt_precede.Size = new System.Drawing.Size(75, 23);
            this.bt_precede.TabIndex = 9;
            this.bt_precede.Text = "Précédent";
            this.bt_precede.UseVisualStyleBackColor = true;
            this.bt_precede.Click += new System.EventHandler(this.bt_precede_Click);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(187, 357);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(75, 23);
            this.bt_next.TabIndex = 10;
            this.bt_next.Text = "Suivant";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_end
            // 
            this.bt_end.Location = new System.Drawing.Point(269, 357);
            this.bt_end.Name = "bt_end";
            this.bt_end.Size = new System.Drawing.Size(75, 23);
            this.bt_end.TabIndex = 11;
            this.bt_end.Text = "Fin";
            this.bt_end.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_end.UseVisualStyleBackColor = true;
            // 
            // lbl_create
            // 
            this.lbl_create.AutoSize = true;
            this.lbl_create.Location = new System.Drawing.Point(159, 113);
            this.lbl_create.Name = "lbl_create";
            this.lbl_create.Size = new System.Drawing.Size(10, 13);
            this.lbl_create.TabIndex = 12;
            this.lbl_create.Text = "-";
            // 
            // lbl_modif
            // 
            this.lbl_modif.AutoSize = true;
            this.lbl_modif.Location = new System.Drawing.Point(159, 148);
            this.lbl_modif.Name = "lbl_modif";
            this.lbl_modif.Size = new System.Drawing.Size(10, 13);
            this.lbl_modif.TabIndex = 13;
            this.lbl_modif.Text = "-";
            // 
            // Site
            // 
            this.Site.Controls.Add(this.txt_City);
            this.Site.Controls.Add(this.lbl_modif);
            this.Site.Controls.Add(this.lbl_City);
            this.Site.Controls.Add(this.lbl_create);
            this.Site.Controls.Add(this.lbl_dateCreate);
            this.Site.Controls.Add(this.lbl_dateModif);
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
            // 
            // FormGererSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 597);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.Site);
            this.Controls.Add(this.bt_end);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_precede);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_sup);
            this.Controls.Add(this.bt_modif);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_new);
            this.Name = "FormGererSites";
            this.Text = "Gérer les sites";
            this.Load += new System.EventHandler(this.FormGererSites_Load);
            this.Site.ResumeLayout(false);
            this.Site.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Label lbl_dateCreate;
        private System.Windows.Forms.Label lbl_dateModif;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_modif;
        private System.Windows.Forms.Button bt_sup;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_precede;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_end;
        private System.Windows.Forms.Label lbl_create;
        private System.Windows.Forms.Label lbl_modif;
        private System.Windows.Forms.GroupBox Site;
        private System.Windows.Forms.Label lbl_id;
    }
}