namespace GESTION_COMMERCIAL
{
    partial class frmSaisie_Fournisseur
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
            this.RegionCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFournisseur = new System.Windows.Forms.DataGridView();
            this.PaysCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.lblEmailcl = new System.Windows.Forms.Label();
            this.lbladresscl = new System.Windows.Forms.Label();
            this.lblRegioncl = new System.Windows.Forms.Label();
            this.lbltelephonecl = new System.Windows.Forms.Label();
            this.lblnomcl = new System.Windows.Forms.Label();
            this.lblpayscl = new System.Windows.Forms.Label();
            this.txtregionf = new System.Windows.Forms.TextBox();
            this.txtPaysf = new System.Windows.Forms.TextBox();
            this.txtemailf = new System.Windows.Forms.TextBox();
            this.txtadressef = new System.Windows.Forms.TextBox();
            this.txttelephonef = new System.Windows.Forms.TextBox();
            this.txtnomf = new System.Windows.Forms.TextBox();
            this.lblNumcl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtnumerof = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegionCl
            // 
            this.RegionCl.HeaderText = "Région";
            this.RegionCl.Name = "RegionCl";
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
            this.dgvFournisseur.Location = new System.Drawing.Point(298, 7);
            this.dgvFournisseur.Name = "dgvFournisseur";
            this.dgvFournisseur.Size = new System.Drawing.Size(743, 272);
            this.dgvFournisseur.TabIndex = 45;
            // 
            // PaysCl
            // 
            this.PaysCl.HeaderText = "Pays";
            this.PaysCl.Name = "PaysCl";
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(199, 303);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(150, 50);
            this.btnajouter.TabIndex = 44;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(355, 303);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(150, 50);
            this.btnmodifier.TabIndex = 43;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(510, 303);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(150, 50);
            this.btnsupprimer.TabIndex = 42;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnquitter
            // 
            this.btnquitter.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitter.Location = new System.Drawing.Point(666, 303);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(150, 50);
            this.btnquitter.TabIndex = 41;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(43, 303);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(150, 50);
            this.btnNouveau.TabIndex = 40;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // lblEmailcl
            // 
            this.lblEmailcl.AutoSize = true;
            this.lblEmailcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailcl.Location = new System.Drawing.Point(39, 134);
            this.lblEmailcl.Name = "lblEmailcl";
            this.lblEmailcl.Size = new System.Drawing.Size(56, 20);
            this.lblEmailcl.TabIndex = 39;
            this.lblEmailcl.Text = "Email :";
            // 
            // lbladresscl
            // 
            this.lbladresscl.AutoSize = true;
            this.lbladresscl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladresscl.Location = new System.Drawing.Point(19, 85);
            this.lbladresscl.Name = "lbladresscl";
            this.lbladresscl.Size = new System.Drawing.Size(76, 20);
            this.lbladresscl.TabIndex = 38;
            this.lbladresscl.Text = "Adresse :";
            // 
            // lblRegioncl
            // 
            this.lblRegioncl.AutoSize = true;
            this.lblRegioncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegioncl.Location = new System.Drawing.Point(27, 186);
            this.lblRegioncl.Name = "lblRegioncl";
            this.lblRegioncl.Size = new System.Drawing.Size(68, 20);
            this.lblRegioncl.TabIndex = 37;
            this.lblRegioncl.Text = "Région :";
            // 
            // lbltelephonecl
            // 
            this.lbltelephonecl.AutoSize = true;
            this.lbltelephonecl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelephonecl.Location = new System.Drawing.Point(3, 59);
            this.lbltelephonecl.Name = "lbltelephonecl";
            this.lbltelephonecl.Size = new System.Drawing.Size(92, 20);
            this.lbltelephonecl.TabIndex = 36;
            this.lbltelephonecl.Text = "Télephone :";
            // 
            // lblnomcl
            // 
            this.lblnomcl.AutoSize = true;
            this.lblnomcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomcl.Location = new System.Drawing.Point(45, 33);
            this.lblnomcl.Name = "lblnomcl";
            this.lblnomcl.Size = new System.Drawing.Size(50, 20);
            this.lblnomcl.TabIndex = 35;
            this.lblnomcl.Text = "Nom :";
            // 
            // lblpayscl
            // 
            this.lblpayscl.AutoSize = true;
            this.lblpayscl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayscl.Location = new System.Drawing.Point(44, 160);
            this.lblpayscl.Name = "lblpayscl";
            this.lblpayscl.Size = new System.Drawing.Size(51, 20);
            this.lblpayscl.TabIndex = 34;
            this.lblpayscl.Text = "Pays :";
            // 
            // txtregionf
            // 
            this.txtregionf.Location = new System.Drawing.Point(101, 186);
            this.txtregionf.Name = "txtregionf";
            this.txtregionf.Size = new System.Drawing.Size(191, 20);
            this.txtregionf.TabIndex = 33;
            // 
            // txtPaysf
            // 
            this.txtPaysf.Location = new System.Drawing.Point(101, 160);
            this.txtPaysf.Name = "txtPaysf";
            this.txtPaysf.Size = new System.Drawing.Size(191, 20);
            this.txtPaysf.TabIndex = 32;
            // 
            // txtemailf
            // 
            this.txtemailf.Location = new System.Drawing.Point(101, 134);
            this.txtemailf.Name = "txtemailf";
            this.txtemailf.Size = new System.Drawing.Size(191, 20);
            this.txtemailf.TabIndex = 31;
            // 
            // txtadressef
            // 
            this.txtadressef.Location = new System.Drawing.Point(101, 85);
            this.txtadressef.Multiline = true;
            this.txtadressef.Name = "txtadressef";
            this.txtadressef.Size = new System.Drawing.Size(191, 43);
            this.txtadressef.TabIndex = 30;
            // 
            // txttelephonef
            // 
            this.txttelephonef.Location = new System.Drawing.Point(101, 59);
            this.txttelephonef.Name = "txttelephonef";
            this.txttelephonef.Size = new System.Drawing.Size(191, 20);
            this.txttelephonef.TabIndex = 29;
            // 
            // txtnomf
            // 
            this.txtnomf.Location = new System.Drawing.Point(101, 33);
            this.txtnomf.Name = "txtnomf";
            this.txtnomf.Size = new System.Drawing.Size(191, 20);
            this.txtnomf.TabIndex = 28;
            // 
            // lblNumcl
            // 
            this.lblNumcl.AutoSize = true;
            this.lblNumcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumcl.Location = new System.Drawing.Point(22, 7);
            this.lblNumcl.Name = "lblNumcl";
            this.lblNumcl.Size = new System.Drawing.Size(73, 20);
            this.lblNumcl.TabIndex = 26;
            this.lblNumcl.Text = "Numéro :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtnumerof
            // 
            this.txtnumerof.Location = new System.Drawing.Point(101, 7);
            this.txtnumerof.Name = "txtnumerof";
            this.txtnumerof.Size = new System.Drawing.Size(191, 20);
            this.txtnumerof.TabIndex = 27;
            // 
            // frmSaisie_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 365);
            this.Controls.Add(this.dgvFournisseur);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.lblEmailcl);
            this.Controls.Add(this.lbladresscl);
            this.Controls.Add(this.lblRegioncl);
            this.Controls.Add(this.lbltelephonecl);
            this.Controls.Add(this.lblnomcl);
            this.Controls.Add(this.lblpayscl);
            this.Controls.Add(this.txtregionf);
            this.Controls.Add(this.txtPaysf);
            this.Controls.Add(this.txtemailf);
            this.Controls.Add(this.txtadressef);
            this.Controls.Add(this.txttelephonef);
            this.Controls.Add(this.txtnomf);
            this.Controls.Add(this.lblNumcl);
            this.Controls.Add(this.txtnumerof);
            this.Name = "frmSaisie_Fournisseur";
            this.Text = "Saisie_Fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn RegionCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numcl;
        private System.Windows.Forms.DataGridView dgvFournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaysCl;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Label lblEmailcl;
        private System.Windows.Forms.Label lbladresscl;
        private System.Windows.Forms.Label lblRegioncl;
        private System.Windows.Forms.Label lbltelephonecl;
        private System.Windows.Forms.Label lblnomcl;
        private System.Windows.Forms.Label lblpayscl;
        private System.Windows.Forms.TextBox txtregionf;
        private System.Windows.Forms.TextBox txtPaysf;
        private System.Windows.Forms.TextBox txtemailf;
        private System.Windows.Forms.TextBox txtadressef;
        private System.Windows.Forms.TextBox txttelephonef;
        private System.Windows.Forms.TextBox txtnomf;
        private System.Windows.Forms.Label lblNumcl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtnumerof;
    }
}