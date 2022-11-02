namespace GESTION_COMMERCIAL
{
    partial class frmRechercheClients
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
            this.grbrecherche = new System.Windows.Forms.GroupBox();
            this.lblRegioncl = new System.Windows.Forms.Label();
            this.lblpayscl = new System.Windows.Forms.Label();
            this.cmbregioncl = new System.Windows.Forms.ComboBox();
            this.cmbPayscl = new System.Windows.Forms.ComboBox();
            this.lblnomcl = new System.Windows.Forms.Label();
            this.txtnomcl = new System.Windows.Forms.TextBox();
            this.txtnumerocl = new System.Windows.Forms.TextBox();
            this.lblNumcl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.Numcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaysCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.grbrecherche.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbrecherche
            // 
            this.grbrecherche.Controls.Add(this.lblRegioncl);
            this.grbrecherche.Controls.Add(this.lblpayscl);
            this.grbrecherche.Controls.Add(this.cmbregioncl);
            this.grbrecherche.Controls.Add(this.cmbPayscl);
            this.grbrecherche.Controls.Add(this.lblnomcl);
            this.grbrecherche.Controls.Add(this.txtnomcl);
            this.grbrecherche.Controls.Add(this.txtnumerocl);
            this.grbrecherche.Controls.Add(this.lblNumcl);
            this.grbrecherche.Location = new System.Drawing.Point(8, 8);
            this.grbrecherche.Name = "grbrecherche";
            this.grbrecherche.Size = new System.Drawing.Size(779, 96);
            this.grbrecherche.TabIndex = 0;
            this.grbrecherche.TabStop = false;
            this.grbrecherche.Text = "Critères de recherche";
            // 
            // lblRegioncl
            // 
            this.lblRegioncl.AutoSize = true;
            this.lblRegioncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegioncl.Location = new System.Drawing.Point(345, 53);
            this.lblRegioncl.Name = "lblRegioncl";
            this.lblRegioncl.Size = new System.Drawing.Size(68, 20);
            this.lblRegioncl.TabIndex = 23;
            this.lblRegioncl.Text = "Région :";
            // 
            // lblpayscl
            // 
            this.lblpayscl.AutoSize = true;
            this.lblpayscl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayscl.Location = new System.Drawing.Point(362, 27);
            this.lblpayscl.Name = "lblpayscl";
            this.lblpayscl.Size = new System.Drawing.Size(51, 20);
            this.lblpayscl.TabIndex = 22;
            this.lblpayscl.Text = "Pays :";
            // 
            // cmbregioncl
            // 
            this.cmbregioncl.FormattingEnabled = true;
            this.cmbregioncl.Location = new System.Drawing.Point(433, 53);
            this.cmbregioncl.Name = "cmbregioncl";
            this.cmbregioncl.Size = new System.Drawing.Size(261, 21);
            this.cmbregioncl.TabIndex = 21;
            // 
            // cmbPayscl
            // 
            this.cmbPayscl.FormattingEnabled = true;
            this.cmbPayscl.Location = new System.Drawing.Point(433, 27);
            this.cmbPayscl.Name = "cmbPayscl";
            this.cmbPayscl.Size = new System.Drawing.Size(261, 21);
            this.cmbPayscl.TabIndex = 20;
            // 
            // lblnomcl
            // 
            this.lblnomcl.AutoSize = true;
            this.lblnomcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomcl.Location = new System.Drawing.Point(41, 54);
            this.lblnomcl.Name = "lblnomcl";
            this.lblnomcl.Size = new System.Drawing.Size(50, 20);
            this.lblnomcl.TabIndex = 19;
            this.lblnomcl.Text = "Nom :";
            // 
            // txtnomcl
            // 
            this.txtnomcl.Location = new System.Drawing.Point(97, 54);
            this.txtnomcl.Name = "txtnomcl";
            this.txtnomcl.Size = new System.Drawing.Size(191, 20);
            this.txtnomcl.TabIndex = 18;
            // 
            // txtnumerocl
            // 
            this.txtnumerocl.Location = new System.Drawing.Point(97, 28);
            this.txtnumerocl.Name = "txtnumerocl";
            this.txtnumerocl.Size = new System.Drawing.Size(191, 20);
            this.txtnumerocl.TabIndex = 17;
            // 
            // lblNumcl
            // 
            this.lblNumcl.AutoSize = true;
            this.lblNumcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumcl.Location = new System.Drawing.Point(18, 28);
            this.lblNumcl.Name = "lblNumcl";
            this.lblNumcl.Size = new System.Drawing.Size(73, 20);
            this.lblNumcl.TabIndex = 16;
            this.lblNumcl.Text = "Numéro :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClient);
            this.panel1.Location = new System.Drawing.Point(6, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 214);
            this.panel1.TabIndex = 1;
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numcl,
            this.Nomcl,
            this.telcl,
            this.AdressCl,
            this.EmailCl,
            this.PaysCl,
            this.RegionCl});
            this.dgvClient.Location = new System.Drawing.Point(3, 3);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(745, 207);
            this.dgvClient.TabIndex = 26;
            // 
            // Numcl
            // 
            this.Numcl.HeaderText = "Numero";
            this.Numcl.Name = "Numcl";
            // 
            // Nomcl
            // 
            this.Nomcl.HeaderText = "Nom";
            this.Nomcl.Name = "Nomcl";
            // 
            // telcl
            // 
            this.telcl.HeaderText = "Télephone";
            this.telcl.Name = "telcl";
            // 
            // AdressCl
            // 
            this.AdressCl.HeaderText = "Adresse";
            this.AdressCl.Name = "AdressCl";
            // 
            // EmailCl
            // 
            this.EmailCl.HeaderText = "Email";
            this.EmailCl.Name = "EmailCl";
            // 
            // PaysCl
            // 
            this.PaysCl.HeaderText = "Pays";
            this.PaysCl.Name = "PaysCl";
            // 
            // RegionCl
            // 
            this.RegionCl.HeaderText = "Région";
            this.RegionCl.Name = "RegionCl";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnajouter);
            this.panel2.Controls.Add(this.btnmodifier);
            this.panel2.Controls.Add(this.btnsupprimer);
            this.panel2.Controls.Add(this.btnquitter);
            this.panel2.Controls.Add(this.btnNouveau);
            this.panel2.Location = new System.Drawing.Point(7, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 55);
            this.panel2.TabIndex = 2;
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(166, 3);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(150, 50);
            this.btnajouter.TabIndex = 29;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(314, 3);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(150, 50);
            this.btnmodifier.TabIndex = 28;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(461, 3);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(150, 50);
            this.btnsupprimer.TabIndex = 27;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnquitter
            // 
            this.btnquitter.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitter.Location = new System.Drawing.Point(611, 3);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(150, 50);
            this.btnquitter.TabIndex = 26;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(20, 3);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(150, 50);
            this.btnNouveau.TabIndex = 25;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // frmRechercheClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbrecherche);
            this.Name = "frmRechercheClients";
            this.Text = "Recherche_Clients";
            this.Load += new System.EventHandler(this.frmRechercheClients_Load);
            this.grbrecherche.ResumeLayout(false);
            this.grbrecherche.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbrecherche;
        private System.Windows.Forms.ComboBox cmbregioncl;
        private System.Windows.Forms.ComboBox cmbPayscl;
        private System.Windows.Forms.Label lblnomcl;
        private System.Windows.Forms.TextBox txtnomcl;
        private System.Windows.Forms.TextBox txtnumerocl;
        private System.Windows.Forms.Label lblNumcl;
        private System.Windows.Forms.Label lblRegioncl;
        private System.Windows.Forms.Label lblpayscl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaysCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionCl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnNouveau;
    }
}