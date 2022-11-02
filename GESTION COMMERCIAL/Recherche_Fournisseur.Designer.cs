namespace GESTION_COMMERCIAL
{
    partial class frmRechercheFournisseur
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
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnquitter = new System.Windows.Forms.Button();
            this.RegionCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaysCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFournisseur = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegioncl = new System.Windows.Forms.Label();
            this.lblpayscl = new System.Windows.Forms.Label();
            this.cmbregionf = new System.Windows.Forms.ComboBox();
            this.cmbPaysf = new System.Windows.Forms.ComboBox();
            this.lblnomcl = new System.Windows.Forms.Label();
            this.txtnomf = new System.Windows.Forms.TextBox();
            this.lblNumcl = new System.Windows.Forms.Label();
            this.grbrecherche = new System.Windows.Forms.GroupBox();
            this.txtnumerof = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseur)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbrecherche.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnajouter);
            this.panel2.Controls.Add(this.btnmodifier);
            this.panel2.Controls.Add(this.btnsupprimer);
            this.panel2.Controls.Add(this.btnquitter);
            this.panel2.Controls.Add(this.btnNouveau);
            this.panel2.Location = new System.Drawing.Point(14, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 55);
            this.panel2.TabIndex = 5;
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
            // 
            // RegionCl
            // 
            this.RegionCl.HeaderText = "Région";
            this.RegionCl.Name = "RegionCl";
            // 
            // PaysCl
            // 
            this.PaysCl.HeaderText = "Pays";
            this.PaysCl.Name = "PaysCl";
            // 
            // EmailCl
            // 
            this.EmailCl.HeaderText = "Email";
            this.EmailCl.Name = "EmailCl";
            // 
            // AdressCl
            // 
            this.AdressCl.HeaderText = "Adresse";
            this.AdressCl.Name = "AdressCl";
            // 
            // telcl
            // 
            this.telcl.HeaderText = "Télephone";
            this.telcl.Name = "telcl";
            // 
            // Nomcl
            // 
            this.Nomcl.HeaderText = "Nom";
            this.Nomcl.Name = "Nomcl";
            // 
            // Numcl
            // 
            this.Numcl.HeaderText = "Numero";
            this.Numcl.Name = "Numcl";
            // 
            // dgvFournisseur
            // 
            this.dgvFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numcl,
            this.Nomcl,
            this.telcl,
            this.AdressCl,
            this.EmailCl,
            this.PaysCl,
            this.RegionCl});
            this.dgvFournisseur.Location = new System.Drawing.Point(8, 3);
            this.dgvFournisseur.Name = "dgvFournisseur";
            this.dgvFournisseur.Size = new System.Drawing.Size(745, 207);
            this.dgvFournisseur.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFournisseur);
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 214);
            this.panel1.TabIndex = 4;
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
            // cmbregionf
            // 
            this.cmbregionf.FormattingEnabled = true;
            this.cmbregionf.Location = new System.Drawing.Point(433, 53);
            this.cmbregionf.Name = "cmbregionf";
            this.cmbregionf.Size = new System.Drawing.Size(261, 21);
            this.cmbregionf.TabIndex = 21;
            // 
            // cmbPaysf
            // 
            this.cmbPaysf.FormattingEnabled = true;
            this.cmbPaysf.Location = new System.Drawing.Point(433, 27);
            this.cmbPaysf.Name = "cmbPaysf";
            this.cmbPaysf.Size = new System.Drawing.Size(261, 21);
            this.cmbPaysf.TabIndex = 20;
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
            // txtnomf
            // 
            this.txtnomf.Location = new System.Drawing.Point(97, 54);
            this.txtnomf.Name = "txtnomf";
            this.txtnomf.Size = new System.Drawing.Size(191, 20);
            this.txtnomf.TabIndex = 18;
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
            // grbrecherche
            // 
            this.grbrecherche.Controls.Add(this.lblRegioncl);
            this.grbrecherche.Controls.Add(this.lblpayscl);
            this.grbrecherche.Controls.Add(this.cmbregionf);
            this.grbrecherche.Controls.Add(this.cmbPaysf);
            this.grbrecherche.Controls.Add(this.lblnomcl);
            this.grbrecherche.Controls.Add(this.txtnomf);
            this.grbrecherche.Controls.Add(this.txtnumerof);
            this.grbrecherche.Controls.Add(this.lblNumcl);
            this.grbrecherche.Location = new System.Drawing.Point(9, -1);
            this.grbrecherche.Name = "grbrecherche";
            this.grbrecherche.Size = new System.Drawing.Size(779, 96);
            this.grbrecherche.TabIndex = 3;
            this.grbrecherche.TabStop = false;
            this.grbrecherche.Text = "Critères de recherche";
            // 
            // txtnumerof
            // 
            this.txtnumerof.Location = new System.Drawing.Point(97, 28);
            this.txtnumerof.Name = "txtnumerof";
            this.txtnumerof.Size = new System.Drawing.Size(191, 20);
            this.txtnumerof.TabIndex = 17;
            // 
            // frmRechercheFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbrecherche);
            this.Name = "frmRechercheFournisseur";
            this.Text = "Recherche_Fournisseur";
            this.Load += new System.EventHandler(this.Recherche_Fournisseur_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbrecherche.ResumeLayout(false);
            this.grbrecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaysCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numcl;
        private System.Windows.Forms.DataGridView dgvFournisseur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegioncl;
        private System.Windows.Forms.Label lblpayscl;
        private System.Windows.Forms.ComboBox cmbregionf;
        private System.Windows.Forms.ComboBox cmbPaysf;
        private System.Windows.Forms.Label lblnomcl;
        private System.Windows.Forms.TextBox txtnomf;
        private System.Windows.Forms.Label lblNumcl;
        private System.Windows.Forms.GroupBox grbrecherche;
        private System.Windows.Forms.TextBox txtnumerof;
    }
}