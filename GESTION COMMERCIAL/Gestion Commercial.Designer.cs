namespace GESTION_COMMERCIAL
{
    partial class Gestion_Commercial
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
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.fournisseurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieDesClientsToolStripMenuItem,
            this.rechercheDesClientsToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientToolStripMenuItem.Text = "Clients";
            // 
            // saisieDesClientsToolStripMenuItem
            // 
            this.saisieDesClientsToolStripMenuItem.Name = "saisieDesClientsToolStripMenuItem";
            this.saisieDesClientsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saisieDesClientsToolStripMenuItem.Text = "Saisie des clients";
            this.saisieDesClientsToolStripMenuItem.Click += new System.EventHandler(this.saisieDesClientsToolStripMenuItem_Click);
            // 
            // rechercheDesClientsToolStripMenuItem
            // 
            this.rechercheDesClientsToolStripMenuItem.Name = "rechercheDesClientsToolStripMenuItem";
            this.rechercheDesClientsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rechercheDesClientsToolStripMenuItem.Text = "Recherche des clients";
            this.rechercheDesClientsToolStripMenuItem.Click += new System.EventHandler(this.rechercheDesClientsToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieUnFournisseurToolStripMenuItem,
            this.rechercheUnFournisseurToolStripMenuItem});
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            this.fournisseurToolStripMenuItem.Click += new System.EventHandler(this.fournisseurToolStripMenuItem_Click);
            // 
            // saisieUnFournisseurToolStripMenuItem
            // 
            this.saisieUnFournisseurToolStripMenuItem.Name = "saisieUnFournisseurToolStripMenuItem";
            this.saisieUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.saisieUnFournisseurToolStripMenuItem.Text = "Saisie un fournisseur";
            this.saisieUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.saisieUnFournisseurToolStripMenuItem_Click);
            // 
            // rechercheUnFournisseurToolStripMenuItem
            // 
            this.rechercheUnFournisseurToolStripMenuItem.Name = "rechercheUnFournisseurToolStripMenuItem";
            this.rechercheUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.rechercheUnFournisseurToolStripMenuItem.Text = "Recherche un fournisseur ";
            this.rechercheUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.rechercheUnFournisseurToolStripMenuItem_Click);
            // 
            // Gestion_Commercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 392);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Gestion_Commercial";
            this.Text = "Gestion_Commercial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheUnFournisseurToolStripMenuItem;
    }
}