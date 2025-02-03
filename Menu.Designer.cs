namespace gsbrapportsEF
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.msVisiteur = new System.Windows.Forms.MenuStrip();
            this.visteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msVisiteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // msVisiteur
            // 
            this.msVisiteur.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msVisiteur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visteurToolStripMenuItem});
            this.msVisiteur.Location = new System.Drawing.Point(0, 0);
            this.msVisiteur.Name = "msVisiteur";
            this.msVisiteur.Size = new System.Drawing.Size(800, 28);
            this.msVisiteur.TabIndex = 0;
            this.msVisiteur.Text = "Visiteur";
            // 
            // visteurToolStripMenuItem
            // 
            this.visteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem,
            this.rapportsToolStripMenuItem});
            this.visteurToolStripMenuItem.Name = "visteurToolStripMenuItem";
            this.visteurToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.visteurToolStripMenuItem.Text = "Visteur";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gérerToolStripMenuItem.Text = "Gérer";
            this.gérerToolStripMenuItem.Click += new System.EventHandler(this.gérerToolStripMenuItem_Click);
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rapportsToolStripMenuItem.Text = "Rapports";
            this.rapportsToolStripMenuItem.Click += new System.EventHandler(this.rapportsToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msVisiteur);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msVisiteur;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.msVisiteur.ResumeLayout(false);
            this.msVisiteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msVisiteur;
        private System.Windows.Forms.ToolStripMenuItem visteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
    }
}

