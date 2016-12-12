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
            this.lstB_Informations = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grBox_CDF = new System.Windows.Forms.GroupBox();
            this.pctBox_CDF = new System.Windows.Forms.PictureBox();
            this.lstBox_CDF = new System.Windows.Forms.ListBox();
            this.grBox_NE = new System.Windows.Forms.GroupBox();
            this.pctBox_NE = new System.Windows.Forms.PictureBox();
            this.lstBox_NE = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grBox_CDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_CDF)).BeginInit();
            this.grBox_NE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_NE)).BeginInit();
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
            this.cbx_Region.Location = new System.Drawing.Point(81, 22);
            this.cbx_Region.Name = "cbx_Region";
            this.cbx_Region.Size = new System.Drawing.Size(591, 21);
            this.cbx_Region.TabIndex = 0;
            this.cbx_Region.SelectedIndexChanged += new System.EventHandler(this.cbx_Region_SelectedIndexChanged);
            // 
            // cbx_Pays
            // 
            this.cbx_Pays.FormattingEnabled = true;
            this.cbx_Pays.Location = new System.Drawing.Point(81, 79);
            this.cbx_Pays.Name = "cbx_Pays";
            this.cbx_Pays.Size = new System.Drawing.Size(591, 21);
            this.cbx_Pays.TabIndex = 1;
            this.cbx_Pays.SelectedIndexChanged += new System.EventHandler(this.cbx_Pays_SelectedIndexChanged);
            // 
            // lbl_Region
            // 
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Location = new System.Drawing.Point(25, 25);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(41, 13);
            this.lbl_Region.TabIndex = 2;
            this.lbl_Region.Text = "Région";
            // 
            // lbl_Pays
            // 
            this.lbl_Pays.AutoSize = true;
            this.lbl_Pays.Location = new System.Drawing.Point(25, 82);
            this.lbl_Pays.Name = "lbl_Pays";
            this.lbl_Pays.Size = new System.Drawing.Size(30, 13);
            this.lbl_Pays.TabIndex = 3;
            this.lbl_Pays.Text = "Pays";
            // 
            // lstB_Informations
            // 
            this.lstB_Informations.FormattingEnabled = true;
            this.lstB_Informations.Location = new System.Drawing.Point(81, 120);
            this.lstB_Informations.Name = "lstB_Informations";
            this.lstB_Informations.Size = new System.Drawing.Size(591, 251);
            this.lstB_Informations.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 411);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbx_Region);
            this.tabPage1.Controls.Add(this.lbl_Region);
            this.tabPage1.Controls.Add(this.lbl_Pays);
            this.tabPage1.Controls.Add(this.lstB_Informations);
            this.tabPage1.Controls.Add(this.cbx_Pays);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grBox_CDF);
            this.tabPage2.Controls.Add(this.grBox_NE);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grBox_CDF
            // 
            this.grBox_CDF.Controls.Add(this.pctBox_CDF);
            this.grBox_CDF.Controls.Add(this.lstBox_CDF);
            this.grBox_CDF.Location = new System.Drawing.Point(412, 44);
            this.grBox_CDF.Name = "grBox_CDF";
            this.grBox_CDF.Size = new System.Drawing.Size(234, 300);
            this.grBox_CDF.TabIndex = 1;
            this.grBox_CDF.TabStop = false;
            this.grBox_CDF.Text = "La Chaux-de-Fonds";
            // 
            // pctBox_CDF
            // 
            this.pctBox_CDF.Location = new System.Drawing.Point(34, 172);
            this.pctBox_CDF.Name = "pctBox_CDF";
            this.pctBox_CDF.Size = new System.Drawing.Size(168, 111);
            this.pctBox_CDF.TabIndex = 2;
            this.pctBox_CDF.TabStop = false;
            // 
            // lstBox_CDF
            // 
            this.lstBox_CDF.FormattingEnabled = true;
            this.lstBox_CDF.Location = new System.Drawing.Point(7, 19);
            this.lstBox_CDF.Name = "lstBox_CDF";
            this.lstBox_CDF.Size = new System.Drawing.Size(221, 134);
            this.lstBox_CDF.TabIndex = 1;
            // 
            // grBox_NE
            // 
            this.grBox_NE.Controls.Add(this.pctBox_NE);
            this.grBox_NE.Controls.Add(this.lstBox_NE);
            this.grBox_NE.Location = new System.Drawing.Point(45, 44);
            this.grBox_NE.Name = "grBox_NE";
            this.grBox_NE.Size = new System.Drawing.Size(234, 300);
            this.grBox_NE.TabIndex = 0;
            this.grBox_NE.TabStop = false;
            this.grBox_NE.Text = "Neuchâtel";
            // 
            // pctBox_NE
            // 
            this.pctBox_NE.Location = new System.Drawing.Point(31, 172);
            this.pctBox_NE.Name = "pctBox_NE";
            this.pctBox_NE.Size = new System.Drawing.Size(168, 111);
            this.pctBox_NE.TabIndex = 1;
            this.pctBox_NE.TabStop = false;
            // 
            // lstBox_NE
            // 
            this.lstBox_NE.FormattingEnabled = true;
            this.lstBox_NE.Location = new System.Drawing.Point(7, 20);
            this.lstBox_NE.Name = "lstBox_NE";
            this.lstBox_NE.Size = new System.Drawing.Size(221, 134);
            this.lstBox_NE.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "JSon Web Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grBox_CDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_CDF)).EndInit();
            this.grBox_NE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_NE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Region;
        private System.Windows.Forms.ComboBox cbx_Pays;
        private System.Windows.Forms.Label lbl_Region;
        private System.Windows.Forms.Label lbl_Pays;
        private System.Windows.Forms.ListBox lstB_Informations;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grBox_CDF;
        private System.Windows.Forms.GroupBox grBox_NE;
        private System.Windows.Forms.ListBox lstBox_CDF;
        private System.Windows.Forms.ListBox lstBox_NE;
        private System.Windows.Forms.PictureBox pctBox_CDF;
        private System.Windows.Forms.PictureBox pctBox_NE;
    }
}

