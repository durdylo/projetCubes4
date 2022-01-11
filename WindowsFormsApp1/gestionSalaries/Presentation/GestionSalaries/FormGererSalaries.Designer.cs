namespace WindowsFormsApp1.gestionSalaries.Presentation.GestionSalaries
{
    partial class FormGererSalaries
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
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.input_site = new System.Windows.Forms.ComboBox();
            this.siteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projet_4IndDataSet = new WindowsFormsApp1.projet_4IndDataSet();
            this.siteTableAdapter = new WindowsFormsApp1.projet_4IndDataSetTableAdapters.SiteTableAdapter();
            this.input_name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_telFix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_telPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.input_service = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projet_4IndDataSet2 = new WindowsFormsApp1.projet_4IndDataSet2();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet_4IndDataSet1 = new WindowsFormsApp1.projet_4IndDataSet1();
            this.serviceTableAdapter = new WindowsFormsApp1.projet_4IndDataSet1TableAdapters.ServiceTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dataSalaries = new System.Windows.Forms.DataGridView();
            this.bt_new = new System.Windows.Forms.Button();
            this.bt_sup = new System.Windows.Forms.Button();
            this.serviceTableAdapter1 = new WindowsFormsApp1.projet_4IndDataSet2TableAdapters.ServiceTableAdapter();
            this.siteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.input_firstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_4IndDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_4IndDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_4IndDataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataSource = typeof(WindowsFormsApp1.gestionSites.Site);
            // 
            // siteBindingSource1
            // 
            this.siteBindingSource1.DataSource = typeof(WindowsFormsApp1.gestionSites.Site);
            // 
            // input_site
            // 
            this.input_site.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.siteBindingSource2, "Id", true));
            this.input_site.DataSource = this.siteBindingSource2;
            this.input_site.DisplayMember = "City";
            this.input_site.FormattingEnabled = true;
            this.input_site.Location = new System.Drawing.Point(115, 259);
            this.input_site.Name = "input_site";
            this.input_site.Size = new System.Drawing.Size(128, 21);
            this.input_site.TabIndex = 0;
            this.input_site.ValueMember = "Id";
            this.input_site.SelectedIndexChanged += new System.EventHandler(this.input_site_SelectedIndexChanged);
            // 
            // siteBindingSource2
            // 
            this.siteBindingSource2.DataMember = "Site";
            this.siteBindingSource2.DataSource = this.projet_4IndDataSet;
            // 
            // projet_4IndDataSet
            // 
            this.projet_4IndDataSet.DataSetName = "projet_4IndDataSet";
            this.projet_4IndDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(115, 64);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(135, 20);
            this.input_name.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teléphone fixe";
            // 
            // input_telFix
            // 
            this.input_telFix.Location = new System.Drawing.Point(115, 135);
            this.input_telFix.Name = "input_telFix";
            this.input_telFix.Size = new System.Drawing.Size(135, 20);
            this.input_telFix.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Teléphone portable";
            // 
            // input_telPort
            // 
            this.input_telPort.Location = new System.Drawing.Point(115, 174);
            this.input_telPort.Name = "input_telPort";
            this.input_telPort.Size = new System.Drawing.Size(135, 20);
            this.input_telPort.TabIndex = 8;
            this.input_telPort.TextChanged += new System.EventHandler(this.input_telPort_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(115, 212);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(189, 20);
            this.input_email.TabIndex = 10;
            this.input_email.TextChanged += new System.EventHandler(this.input_email_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Site";
            // 
            // input_service
            // 
            this.input_service.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.serviceBindingSource1, "Id", true));
            this.input_service.DataSource = this.serviceBindingSource1;
            this.input_service.DisplayMember = "Name";
            this.input_service.FormattingEnabled = true;
            this.input_service.Location = new System.Drawing.Point(115, 299);
            this.input_service.Name = "input_service";
            this.input_service.Size = new System.Drawing.Size(121, 21);
            this.input_service.TabIndex = 13;
            this.input_service.ValueMember = "Id";
            this.input_service.SelectedIndexChanged += new System.EventHandler(this.input_service_SelectedIndexChanged);
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            this.serviceBindingSource1.DataSource = this.projet_4IndDataSet2;
            // 
            // projet_4IndDataSet2
            // 
            this.projet_4IndDataSet2.DataSetName = "projet_4IndDataSet2";
            this.projet_4IndDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.projet_4IndDataSet1;
            // 
            // projet_4IndDataSet1
            // 
            this.projet_4IndDataSet1.DataSetName = "projet_4IndDataSet1";
            this.projet_4IndDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(902, 25);
            this.fillByToolStrip.TabIndex = 14;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Service";
            // 
            // dataSalaries
            // 
            this.dataSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalaries.Location = new System.Drawing.Point(350, 28);
            this.dataSalaries.Name = "dataSalaries";
            this.dataSalaries.Size = new System.Drawing.Size(521, 349);
            this.dataSalaries.TabIndex = 16;
            this.dataSalaries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataSalaries.DoubleClick += new System.EventHandler(this.dataSalaries_DoubleClick);
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(115, 378);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 23);
            this.bt_new.TabIndex = 17;
            this.bt_new.Text = "Ajouter";
            this.bt_new.UseVisualStyleBackColor = false;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // bt_sup
            // 
            this.bt_sup.Location = new System.Drawing.Point(219, 378);
            this.bt_sup.Name = "bt_sup";
            this.bt_sup.Size = new System.Drawing.Size(75, 23);
            this.bt_sup.TabIndex = 18;
            this.bt_sup.Text = "Supprimer";
            this.bt_sup.UseVisualStyleBackColor = true;
            this.bt_sup.Click += new System.EventHandler(this.bt_sup_Click);
            // 
            // serviceTableAdapter1
            // 
            this.serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // siteBindingSource3
            // 
            this.siteBindingSource3.DataSource = typeof(WindowsFormsApp1.gestionSites.Site);
            // 
            // input_firstName
            // 
            this.input_firstName.Location = new System.Drawing.Point(115, 96);
            this.input_firstName.Name = "input_firstName";
            this.input_firstName.Size = new System.Drawing.Size(135, 20);
            this.input_firstName.TabIndex = 19;
            this.input_firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormGererSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 496);
            this.Controls.Add(this.input_firstName);
            this.Controls.Add(this.bt_sup);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.dataSalaries);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.input_service);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_telPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_telFix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.input_site);
            this.Name = "FormGererSalaries";
            this.Text = "$";
            this.Load += new System.EventHandler(this.FormGererSalaries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_4IndDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_4IndDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_4IndDataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource siteBindingSource;
        private System.Windows.Forms.BindingSource siteBindingSource1;
        private System.Windows.Forms.ComboBox input_site;
        private projet_4IndDataSet projet_4IndDataSet;
        private System.Windows.Forms.BindingSource siteBindingSource2;
        private projet_4IndDataSetTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_telFix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_telPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox input_service;
        private projet_4IndDataSet1 projet_4IndDataSet1;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private projet_4IndDataSet1TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataSalaries;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Button bt_sup;
        private projet_4IndDataSet2 projet_4IndDataSet2;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private projet_4IndDataSet2TableAdapters.ServiceTableAdapter serviceTableAdapter1;
        private System.Windows.Forms.BindingSource siteBindingSource3;
        private System.Windows.Forms.TextBox input_firstName;
    }
}