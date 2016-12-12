namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.cbx_Region = new System.Windows.Forms.ComboBox();
            this.cbx_Pays = new System.Windows.Forms.ComboBox();
            this.lbl_Region = new System.Windows.Forms.Label();
            this.lbl_Pays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_Region
            // 
            this.cbx_Region.FormattingEnabled = true;
            this.cbx_Region.Items.AddRange(new object[] {
            "Oceania",
            "Americas",
            "Europe",
            "Africa",
            "Asia"});
            this.cbx_Region.Location = new System.Drawing.Point(75, 21);
            this.cbx_Region.Name = "cbx_Region";
            this.cbx_Region.Size = new System.Drawing.Size(591, 21);
            this.cbx_Region.TabIndex = 0;
            this.cbx_Region.SelectedIndexChanged += new System.EventHandler(this.cbx_Region_SelectedIndexChanged);
            // 
            // cbx_Pays
            // 
            this.cbx_Pays.FormattingEnabled = true;
            this.cbx_Pays.Location = new System.Drawing.Point(75, 68);
            this.cbx_Pays.Name = "cbx_Pays";
            this.cbx_Pays.Size = new System.Drawing.Size(591, 21);
            this.cbx_Pays.TabIndex = 1;
            this.cbx_Pays.SelectedIndexChanged += new System.EventHandler(this.cbx_Pays_SelectedIndexChanged);
            // 
            // lbl_Region
            // 
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Location = new System.Drawing.Point(12, 24);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(41, 13);
            this.lbl_Region.TabIndex = 2;
            this.lbl_Region.Text = "Région";
            // 
            // lbl_Pays
            // 
            this.lbl_Pays.AutoSize = true;
            this.lbl_Pays.Location = new System.Drawing.Point(12, 71);
            this.lbl_Pays.Name = "lbl_Pays";
            this.lbl_Pays.Size = new System.Drawing.Size(30, 13);
            this.lbl_Pays.TabIndex = 3;
            this.lbl_Pays.Text = "Pays";
            this.lbl_Pays.Click += new System.EventHandler(this.lbl_Pays_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 383);
            this.Controls.Add(this.lbl_Pays);
            this.Controls.Add(this.lbl_Region);
            this.Controls.Add(this.cbx_Pays);
            this.Controls.Add(this.cbx_Region);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Region;
        private System.Windows.Forms.ComboBox cbx_Pays;
        private System.Windows.Forms.Label lbl_Region;
        private System.Windows.Forms.Label lbl_Pays;
    }
}

