namespace GESTION_COMMERCIAL
{
    partial class frmSaisieClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNumcl = new System.Windows.Forms.Label();
            this.txtnumerocl = new System.Windows.Forms.TextBox();
            this.txtnomcl = new System.Windows.Forms.TextBox();
            this.txtadressecl = new System.Windows.Forms.TextBox();
            this.txttelephonecl = new System.Windows.Forms.TextBox();
            this.txtRegioncl = new System.Windows.Forms.TextBox();
            this.txtPayscl = new System.Windows.Forms.TextBox();
            this.txtemailcl = new System.Windows.Forms.TextBox();
            this.lblpayscl = new System.Windows.Forms.Label();
            this.lblnomcl = new System.Windows.Forms.Label();
            this.lbltelephonecl = new System.Windows.Forms.Label();
            this.lblRegioncl = new System.Windows.Forms.Label();
            this.lbladresscl = new System.Windows.Forms.Label();
            this.lblEmailcl = new System.Windows.Forms.Label();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.Numcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaysCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNumcl
            // 
            this.lblNumcl.AutoSize = true;
            this.lblNumcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumcl.Location = new System.Drawing.Point(17, 15);
            this.lblNumcl.Name = "lblNumcl";
            this.lblNumcl.Size = new System.Drawing.Size(73, 20);
            this.lblNumcl.TabIndex = 0;
            this.lblNumcl.Text = "Numéro :";
            this.lblNumcl.Click += new System.EventHandler(this.lblNumcl_Click);
            // 
            // txtnumerocl
            // 
            this.txtnumerocl.Location = new System.Drawing.Point(96, 15);
            this.txtnumerocl.Name = "txtnumerocl";
            this.txtnumerocl.Size = new System.Drawing.Size(191, 20);
            this.txtnumerocl.TabIndex = 1;
            // 
            // txtnomcl
            // 
            this.txtnomcl.Location = new System.Drawing.Point(96, 41);
            this.txtnomcl.Name = "txtnomcl";
            this.txtnomcl.Size = new System.Drawing.Size(191, 20);
            this.txtnomcl.TabIndex = 3;
            // 
            // txtadressecl
            // 
            this.txtadressecl.Location = new System.Drawing.Point(96, 93);
            this.txtadressecl.Multiline = true;
            this.txtadressecl.Name = "txtadressecl";
            this.txtadressecl.Size = new System.Drawing.Size(191, 43);
            this.txtadressecl.TabIndex = 7;
            this.txtadressecl.TextChanged += new System.EventHandler(this.txtadressecl_TextChanged);
            // 
            // txttelephonecl
            // 
            this.txttelephonecl.Location = new System.Drawing.Point(96, 67);
            this.txttelephonecl.Name = "txttelephonecl";
            this.txttelephonecl.Size = new System.Drawing.Size(191, 20);
            this.txttelephonecl.TabIndex = 5;
            // 
            // txtRegioncl
            // 
            this.txtRegioncl.Location = new System.Drawing.Point(96, 194);
            this.txtRegioncl.Name = "txtRegioncl";
            this.txtRegioncl.Size = new System.Drawing.Size(191, 20);
            this.txtRegioncl.TabIndex = 13;
            // 
            // txtPayscl
            // 
            this.txtPayscl.Location = new System.Drawing.Point(96, 168);
            this.txtPayscl.Name = "txtPayscl";
            this.txtPayscl.Size = new System.Drawing.Size(191, 20);
            this.txtPayscl.TabIndex = 11;
            // 
            // txtemailcl
            // 
            this.txtemailcl.Location = new System.Drawing.Point(96, 142);
            this.txtemailcl.Name = "txtemailcl";
            this.txtemailcl.Size = new System.Drawing.Size(191, 20);
            this.txtemailcl.TabIndex = 9;
            // 
            // lblpayscl
            // 
            this.lblpayscl.AutoSize = true;
            this.lblpayscl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayscl.Location = new System.Drawing.Point(39, 168);
            this.lblpayscl.Name = "lblpayscl";
            this.lblpayscl.Size = new System.Drawing.Size(51, 20);
            this.lblpayscl.TabIndex = 14;
            this.lblpayscl.Text = "Pays :";
            // 
            // lblnomcl
            // 
            this.lblnomcl.AutoSize = true;
            this.lblnomcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomcl.Location = new System.Drawing.Point(40, 41);
            this.lblnomcl.Name = "lblnomcl";
            this.lblnomcl.Size = new System.Drawing.Size(50, 20);
            this.lblnomcl.TabIndex = 15;
            this.lblnomcl.Text = "Nom :";
            // 
            // lbltelephonecl
            // 
            this.lbltelephonecl.AutoSize = true;
            this.lbltelephonecl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelephonecl.Location = new System.Drawing.Point(-2, 67);
            this.lbltelephonecl.Name = "lbltelephonecl";
            this.lbltelephonecl.Size = new System.Drawing.Size(92, 20);
            this.lbltelephonecl.TabIndex = 16;
            this.lbltelephonecl.Text = "Télephone :";
            // 
            // lblRegioncl
            // 
            this.lblRegioncl.AutoSize = true;
            this.lblRegioncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegioncl.Location = new System.Drawing.Point(22, 194);
            this.lblRegioncl.Name = "lblRegioncl";
            this.lblRegioncl.Size = new System.Drawing.Size(68, 20);
            this.lblRegioncl.TabIndex = 17;
            this.lblRegioncl.Text = "Région :";
            // 
            // lbladresscl
            // 
            this.lbladresscl.AutoSize = true;
            this.lbladresscl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladresscl.Location = new System.Drawing.Point(14, 93);
            this.lbladresscl.Name = "lbladresscl";
            this.lbladresscl.Size = new System.Drawing.Size(76, 20);
            this.lbladresscl.TabIndex = 18;
            this.lbladresscl.Text = "Adresse :";
            // 
            // lblEmailcl
            // 
            this.lblEmailcl.AutoSize = true;
            this.lblEmailcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailcl.Location = new System.Drawing.Point(34, 142);
            this.lblEmailcl.Name = "lblEmailcl";
            this.lblEmailcl.Size = new System.Drawing.Size(56, 20);
            this.lblEmailcl.TabIndex = 19;
            this.lblEmailcl.Text = "Email :";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(131, 325);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(150, 50);
            this.btnNouveau.TabIndex = 20;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnquitter
            // 
            this.btnquitter.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitter.Location = new System.Drawing.Point(741, 325);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(150, 50);
            this.btnquitter.TabIndex = 21;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(589, 325);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(150, 50);
            this.btnsupprimer.TabIndex = 22;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(437, 325);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(150, 50);
            this.btnmodifier.TabIndex = 23;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(284, 325);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(150, 50);
            this.btnajouter.TabIndex = 24;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // dgvClient
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numcl,
            this.Nomcl,
            this.telcl,
            this.AdressCl,
            this.EmailCl,
            this.PaysCl,
            this.RegionCl});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClient.Location = new System.Drawing.Point(293, 15);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(743, 272);
            this.dgvClient.TabIndex = 25;
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
            // frmSaisieClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.dgvClient);
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
            this.Controls.Add(this.txtRegioncl);
            this.Controls.Add(this.txtPayscl);
            this.Controls.Add(this.txtemailcl);
            this.Controls.Add(this.txtadressecl);
            this.Controls.Add(this.txttelephonecl);
            this.Controls.Add(this.txtnomcl);
            this.Controls.Add(this.txtnumerocl);
            this.Controls.Add(this.lblNumcl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSaisieClient";
            this.Text = "Saisie Des Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblEmailcl;
        private System.Windows.Forms.Label lbladresscl;
        private System.Windows.Forms.Label lblRegioncl;
        private System.Windows.Forms.Label lbltelephonecl;
        private System.Windows.Forms.Label lblnomcl;
        private System.Windows.Forms.Label lblpayscl;
        private System.Windows.Forms.TextBox txtRegioncl;
        private System.Windows.Forms.TextBox txtPayscl;
        private System.Windows.Forms.TextBox txtemailcl;
        private System.Windows.Forms.TextBox txtadressecl;
        private System.Windows.Forms.TextBox txttelephonecl;
        private System.Windows.Forms.TextBox txtnomcl;
        private System.Windows.Forms.TextBox txtnumerocl;
        private System.Windows.Forms.Label lblNumcl;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaysCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionCl;
    }
}

