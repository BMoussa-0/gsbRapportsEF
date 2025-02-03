namespace gsbrapportsEF
{
    partial class FrmRapport
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
            this.dtgvRapport = new System.Windows.Forms.DataGridView();
            this.bdgsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.lblidVisiteur = new System.Windows.Forms.Label();
            this.cmbVisiteur = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgsRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRapport
            // 
            this.dtgvRapport.AutoGenerateColumns = false;
            this.dtgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn,
            this.medecinDataGridViewTextBoxColumn,
            this.offrirsDataGridViewTextBoxColumn,
            this.visiteurDataGridViewTextBoxColumn});
            this.dtgvRapport.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.dtgvRapport.DataSource = this.bdgsRapport;
            this.dtgvRapport.Location = new System.Drawing.Point(50, 134);
            this.dtgvRapport.Name = "dtgvRapport";
            this.dtgvRapport.RowHeadersWidth = 51;
            this.dtgvRapport.RowTemplate.Height = 24;
            this.dtgvRapport.Size = new System.Drawing.Size(1044, 267);
            this.dtgvRapport.TabIndex = 0;
            this.dtgvRapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRapport_CellContentClick);
            // 
            // bdgsRapport
            // 
            this.bdgsRapport.DataSource = typeof(gsbrapportsEF.rapport);
            // 
            // lblidVisiteur
            // 
            this.lblidVisiteur.AutoSize = true;
            this.lblidVisiteur.Location = new System.Drawing.Point(433, 82);
            this.lblidVisiteur.Name = "lblidVisiteur";
            this.lblidVisiteur.Size = new System.Drawing.Size(62, 16);
            this.lblidVisiteur.TabIndex = 3;
            this.lblidVisiteur.Text = "idVisiteur";
            // 
            // cmbVisiteur
            // 
            this.cmbVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgsRapport, "idVisiteur", true));
            this.cmbVisiteur.FormattingEnabled = true;
            this.cmbVisiteur.Location = new System.Drawing.Point(501, 82);
            this.cmbVisiteur.Name = "cmbVisiteur";
            this.cmbVisiteur.Size = new System.Drawing.Size(121, 24);
            this.cmbVisiteur.TabIndex = 4;
            this.cmbVisiteur.SelectedIndexChanged += new System.EventHandler(this.cmbVisiteur_SelectedIndexChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.Width = 125;
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            this.bilanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            this.idVisiteurDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.Width = 125;
            // 
            // medecinDataGridViewTextBoxColumn
            // 
            this.medecinDataGridViewTextBoxColumn.DataPropertyName = "medecin";
            this.medecinDataGridViewTextBoxColumn.HeaderText = "medecin";
            this.medecinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medecinDataGridViewTextBoxColumn.Name = "medecinDataGridViewTextBoxColumn";
            this.medecinDataGridViewTextBoxColumn.Width = 125;
            // 
            // offrirsDataGridViewTextBoxColumn
            // 
            this.offrirsDataGridViewTextBoxColumn.DataPropertyName = "offrirs";
            this.offrirsDataGridViewTextBoxColumn.HeaderText = "offrirs";
            this.offrirsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offrirsDataGridViewTextBoxColumn.Name = "offrirsDataGridViewTextBoxColumn";
            this.offrirsDataGridViewTextBoxColumn.Width = 125;
            // 
            // visiteurDataGridViewTextBoxColumn
            // 
            this.visiteurDataGridViewTextBoxColumn.DataPropertyName = "visiteur";
            this.visiteurDataGridViewTextBoxColumn.HeaderText = "visiteur";
            this.visiteurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visiteurDataGridViewTextBoxColumn.Name = "visiteurDataGridViewTextBoxColumn";
            this.visiteurDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.cmbVisiteur);
            this.Controls.Add(this.lblidVisiteur);
            this.Controls.Add(this.dtgvRapport);
            this.Name = "FrmRapport";
            this.Text = "FrmRapport";
            this.Load += new System.EventHandler(this.FrmRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgsRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdgsRapport;
        private System.Windows.Forms.DataGridView dtgvRapport;
        private System.Windows.Forms.Label lblidVisiteur;
        private System.Windows.Forms.ComboBox cmbVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiteurDataGridViewTextBoxColumn;
    }
}