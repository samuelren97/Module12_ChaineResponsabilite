namespace POOII_Module12_TraitementImages
{
    partial class fPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msPrincipal = new MenuStrip();
            tsmiFichier = new ToolStripMenuItem();
            tsfmiOuvrir = new ToolStripMenuItem();
            scPrincipal = new SplitContainer();
            scSuiteTraitements = new SplitContainer();
            lbSuiteTraitementAAppliquer = new ListBox();
            panel1 = new Panel();
            bAppliquerSuiteTraitement = new Button();
            pControlSuiteTraitements = new Panel();
            bSupprimerTraitement = new Button();
            bAjouterTraitement = new Button();
            bSuiteTraitementDeplacerBas = new Button();
            bSuiteTraitementDeplacerHaut = new Button();
            cbTraitementAAjouter = new ComboBox();
            pgProprieteTraitementSelectionne = new PropertyGrid();
            pCanvas = new Panel();
            pbImage = new PictureBox();
            msPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scPrincipal).BeginInit();
            scPrincipal.Panel1.SuspendLayout();
            scPrincipal.Panel2.SuspendLayout();
            scPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scSuiteTraitements).BeginInit();
            scSuiteTraitements.Panel1.SuspendLayout();
            scSuiteTraitements.Panel2.SuspendLayout();
            scSuiteTraitements.SuspendLayout();
            panel1.SuspendLayout();
            pControlSuiteTraitements.SuspendLayout();
            pCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // msPrincipal
            // 
            msPrincipal.ImageScalingSize = new Size(20, 20);
            msPrincipal.Items.AddRange(new ToolStripItem[] { tsmiFichier });
            msPrincipal.Location = new Point(0, 0);
            msPrincipal.Name = "msPrincipal";
            msPrincipal.Padding = new Padding(5, 2, 0, 2);
            msPrincipal.Size = new Size(1213, 24);
            msPrincipal.TabIndex = 0;
            msPrincipal.Text = "menuStrip1";
            // 
            // tsmiFichier
            // 
            tsmiFichier.DropDownItems.AddRange(new ToolStripItem[] { tsfmiOuvrir });
            tsmiFichier.Name = "tsmiFichier";
            tsmiFichier.Size = new Size(54, 20);
            tsmiFichier.Text = "&Fichier";
            // 
            // tsfmiOuvrir
            // 
            tsfmiOuvrir.Name = "tsfmiOuvrir";
            tsfmiOuvrir.Size = new Size(107, 22);
            tsfmiOuvrir.Text = "&Ouvrir";
            tsfmiOuvrir.Click += tsfmiOuvrir_Click;
            // 
            // scPrincipal
            // 
            scPrincipal.BorderStyle = BorderStyle.Fixed3D;
            scPrincipal.Dock = DockStyle.Fill;
            scPrincipal.Location = new Point(0, 24);
            scPrincipal.Margin = new Padding(3, 2, 3, 2);
            scPrincipal.Name = "scPrincipal";
            // 
            // scPrincipal.Panel1
            // 
            scPrincipal.Panel1.Controls.Add(scSuiteTraitements);
            // 
            // scPrincipal.Panel2
            // 
            scPrincipal.Panel2.Controls.Add(pCanvas);
            scPrincipal.Size = new Size(1213, 457);
            scPrincipal.SplitterDistance = 294;
            scPrincipal.TabIndex = 1;
            // 
            // scSuiteTraitements
            // 
            scSuiteTraitements.BorderStyle = BorderStyle.Fixed3D;
            scSuiteTraitements.Dock = DockStyle.Fill;
            scSuiteTraitements.Location = new Point(0, 0);
            scSuiteTraitements.Margin = new Padding(3, 2, 3, 2);
            scSuiteTraitements.Name = "scSuiteTraitements";
            scSuiteTraitements.Orientation = Orientation.Horizontal;
            // 
            // scSuiteTraitements.Panel1
            // 
            scSuiteTraitements.Panel1.Controls.Add(lbSuiteTraitementAAppliquer);
            scSuiteTraitements.Panel1.Controls.Add(panel1);
            scSuiteTraitements.Panel1.Controls.Add(pControlSuiteTraitements);
            // 
            // scSuiteTraitements.Panel2
            // 
            scSuiteTraitements.Panel2.Controls.Add(pgProprieteTraitementSelectionne);
            scSuiteTraitements.Size = new Size(294, 457);
            scSuiteTraitements.SplitterDistance = 223;
            scSuiteTraitements.SplitterWidth = 3;
            scSuiteTraitements.TabIndex = 0;
            // 
            // lbSuiteTraitementAAppliquer
            // 
            lbSuiteTraitementAAppliquer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSuiteTraitementAAppliquer.FormattingEnabled = true;
            lbSuiteTraitementAAppliquer.ItemHeight = 15;
            lbSuiteTraitementAAppliquer.Location = new Point(3, 80);
            lbSuiteTraitementAAppliquer.Margin = new Padding(3, 2, 3, 2);
            lbSuiteTraitementAAppliquer.Name = "lbSuiteTraitementAAppliquer";
            lbSuiteTraitementAAppliquer.Size = new Size(285, 79);
            lbSuiteTraitementAAppliquer.TabIndex = 2;
            lbSuiteTraitementAAppliquer.SelectedIndexChanged += lbSuiteTraitementAAppliquer_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(bAppliquerSuiteTraitement);
            panel1.Location = new Point(5, 169);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 38);
            panel1.TabIndex = 1;
            // 
            // bAppliquerSuiteTraitement
            // 
            bAppliquerSuiteTraitement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bAppliquerSuiteTraitement.Location = new Point(0, 8);
            bAppliquerSuiteTraitement.Margin = new Padding(3, 2, 3, 2);
            bAppliquerSuiteTraitement.Name = "bAppliquerSuiteTraitement";
            bAppliquerSuiteTraitement.Size = new Size(280, 22);
            bAppliquerSuiteTraitement.TabIndex = 0;
            bAppliquerSuiteTraitement.Text = "Appliquer";
            bAppliquerSuiteTraitement.UseVisualStyleBackColor = true;
            bAppliquerSuiteTraitement.Click += bAppliquerSuiteTraitement_Click;
            // 
            // pControlSuiteTraitements
            // 
            pControlSuiteTraitements.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pControlSuiteTraitements.Controls.Add(bSupprimerTraitement);
            pControlSuiteTraitements.Controls.Add(bAjouterTraitement);
            pControlSuiteTraitements.Controls.Add(bSuiteTraitementDeplacerBas);
            pControlSuiteTraitements.Controls.Add(bSuiteTraitementDeplacerHaut);
            pControlSuiteTraitements.Controls.Add(cbTraitementAAjouter);
            pControlSuiteTraitements.Location = new Point(3, 2);
            pControlSuiteTraitements.Margin = new Padding(3, 2, 3, 2);
            pControlSuiteTraitements.Name = "pControlSuiteTraitements";
            pControlSuiteTraitements.Size = new Size(285, 73);
            pControlSuiteTraitements.TabIndex = 0;
            // 
            // bSupprimerTraitement
            // 
            bSupprimerTraitement.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bSupprimerTraitement.Location = new Point(252, 42);
            bSupprimerTraitement.Margin = new Padding(3, 2, 3, 2);
            bSupprimerTraitement.Name = "bSupprimerTraitement";
            bSupprimerTraitement.Size = new Size(28, 22);
            bSupprimerTraitement.TabIndex = 4;
            bSupprimerTraitement.Text = "-";
            bSupprimerTraitement.UseVisualStyleBackColor = true;
            bSupprimerTraitement.Click += bSupprimerTraitement_Click;
            // 
            // bAjouterTraitement
            // 
            bAjouterTraitement.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAjouterTraitement.Location = new Point(219, 42);
            bAjouterTraitement.Margin = new Padding(3, 2, 3, 2);
            bAjouterTraitement.Name = "bAjouterTraitement";
            bAjouterTraitement.Size = new Size(28, 22);
            bAjouterTraitement.TabIndex = 3;
            bAjouterTraitement.Text = "+";
            bAjouterTraitement.UseVisualStyleBackColor = true;
            bAjouterTraitement.Click += bAjouterTraitement_Click;
            // 
            // bSuiteTraitementDeplacerBas
            // 
            bSuiteTraitementDeplacerBas.Location = new Point(42, 42);
            bSuiteTraitementDeplacerBas.Margin = new Padding(3, 2, 3, 2);
            bSuiteTraitementDeplacerBas.Name = "bSuiteTraitementDeplacerBas";
            bSuiteTraitementDeplacerBas.Size = new Size(29, 22);
            bSuiteTraitementDeplacerBas.TabIndex = 2;
            bSuiteTraitementDeplacerBas.Text = "v";
            bSuiteTraitementDeplacerBas.UseVisualStyleBackColor = true;
            bSuiteTraitementDeplacerBas.Click += bSuiteTraitementDeplacerBas_Click;
            // 
            // bSuiteTraitementDeplacerHaut
            // 
            bSuiteTraitementDeplacerHaut.Location = new Point(8, 42);
            bSuiteTraitementDeplacerHaut.Margin = new Padding(3, 2, 3, 2);
            bSuiteTraitementDeplacerHaut.Name = "bSuiteTraitementDeplacerHaut";
            bSuiteTraitementDeplacerHaut.Size = new Size(29, 22);
            bSuiteTraitementDeplacerHaut.TabIndex = 1;
            bSuiteTraitementDeplacerHaut.Text = "^";
            bSuiteTraitementDeplacerHaut.UseVisualStyleBackColor = true;
            bSuiteTraitementDeplacerHaut.Click += bSuiteTraitementDeplacerHaut_Click;
            // 
            // cbTraitementAAjouter
            // 
            cbTraitementAAjouter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTraitementAAjouter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTraitementAAjouter.FormattingEnabled = true;
            cbTraitementAAjouter.Location = new Point(3, 2);
            cbTraitementAAjouter.Margin = new Padding(3, 2, 3, 2);
            cbTraitementAAjouter.Name = "cbTraitementAAjouter";
            cbTraitementAAjouter.Size = new Size(280, 23);
            cbTraitementAAjouter.TabIndex = 0;
            // 
            // pgProprieteTraitementSelectionne
            // 
            pgProprieteTraitementSelectionne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pgProprieteTraitementSelectionne.Location = new Point(3, 2);
            pgProprieteTraitementSelectionne.Margin = new Padding(3, 2, 3, 2);
            pgProprieteTraitementSelectionne.Name = "pgProprieteTraitementSelectionne";
            pgProprieteTraitementSelectionne.Size = new Size(286, 226);
            pgProprieteTraitementSelectionne.TabIndex = 0;
            // 
            // pCanvas
            // 
            pCanvas.AutoScroll = true;
            pCanvas.BackColor = Color.White;
            pCanvas.Controls.Add(pbImage);
            pCanvas.Dock = DockStyle.Fill;
            pCanvas.Location = new Point(0, 0);
            pCanvas.Margin = new Padding(3, 2, 3, 2);
            pCanvas.Name = "pCanvas";
            pCanvas.Size = new Size(911, 453);
            pCanvas.TabIndex = 0;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(3, 2);
            pbImage.Margin = new Padding(3, 2, 3, 2);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(109, 46);
            pbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // fPrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 481);
            Controls.Add(scPrincipal);
            Controls.Add(msPrincipal);
            MainMenuStrip = msPrincipal;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1229, 520);
            Name = "fPrincipale";
            Text = "Traitement d'images";
            Load += fPrincipale_Load;
            msPrincipal.ResumeLayout(false);
            msPrincipal.PerformLayout();
            scPrincipal.Panel1.ResumeLayout(false);
            scPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scPrincipal).EndInit();
            scPrincipal.ResumeLayout(false);
            scSuiteTraitements.Panel1.ResumeLayout(false);
            scSuiteTraitements.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scSuiteTraitements).EndInit();
            scSuiteTraitements.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pControlSuiteTraitements.ResumeLayout(false);
            pCanvas.ResumeLayout(false);
            pCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msPrincipal;
        private ToolStripMenuItem tsmiFichier;
        private SplitContainer scPrincipal;
        private SplitContainer scSuiteTraitements;
        private Panel pControlSuiteTraitements;
        private Button bSuiteTraitementDeplacerHaut;
        private ComboBox cbTraitementAAjouter;
        private Button bSuiteTraitementDeplacerBas;
        private Panel panel1;
        private Button bSupprimerTraitement;
        private Button bAjouterTraitement;
        private ListBox lbSuiteTraitementAAppliquer;
        private Button bAppliquerSuiteTraitement;
        private PropertyGrid pgProprieteTraitementSelectionne;
        private Panel pCanvas;
        private PictureBox pbImage;
        private ToolStripMenuItem tsfmiOuvrir;
    }
}