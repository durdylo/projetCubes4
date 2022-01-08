namespace WindowsFormsApp1.gestionServices.Présentation.GestionServices
{
    partial class FormGererServices
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.bt_new = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSerciceView = new System.Windows.Forms.DataGridView();
            this.bt_sup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSerciceView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(157, 137);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(53, 137);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(81, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nom du service";
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(298, 132);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 23);
            this.bt_new.TabIndex = 3;
            this.bt_new.Text = "Ajouter";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(363, 274);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(10, 13);
            this.lbl_id.TabIndex = 20;
            this.lbl_id.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Service";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataSerciceView
            // 
            this.dataSerciceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSerciceView.Location = new System.Drawing.Point(412, 53);
            this.dataSerciceView.Name = "dataSerciceView";
            this.dataSerciceView.Size = new System.Drawing.Size(367, 288);
            this.dataSerciceView.TabIndex = 26;
            this.dataSerciceView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataSerciceView.DoubleClick += new System.EventHandler(this.dataSerciceView_DoubleClick);
            // 
            // bt_sup
            // 
            this.bt_sup.Location = new System.Drawing.Point(298, 205);
            this.bt_sup.Name = "bt_sup";
            this.bt_sup.Size = new System.Drawing.Size(75, 23);
            this.bt_sup.TabIndex = 27;
            this.bt_sup.Text = "Supprimer";
            this.bt_sup.UseVisualStyleBackColor = true;
            this.bt_sup.Click += new System.EventHandler(this.bt_sup_Click);
            // 
            // FormGererServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_sup);
            this.Controls.Add(this.dataSerciceView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Name = "FormGererServices";
            this.Text = "FormGererServices";
            this.Load += new System.EventHandler(this.FormGererServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSerciceView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSerciceView;
        private System.Windows.Forms.Button bt_sup;
    }
}