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
            fichierToolStripMenuItem = new ToolStripMenuItem();
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
            msPrincipal.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem });
            msPrincipal.Location = new Point(0, 0);
            msPrincipal.Name = "msPrincipal";
            msPrincipal.Size = new Size(1384, 28);
            msPrincipal.TabIndex = 0;
            msPrincipal.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // scPrincipal
            // 
            scPrincipal.Dock = DockStyle.Fill;
            scPrincipal.Location = new Point(0, 28);
            scPrincipal.Name = "scPrincipal";
            // 
            // scPrincipal.Panel1
            // 
            scPrincipal.Panel1.Controls.Add(scSuiteTraitements);
            // 
            // scPrincipal.Panel2
            // 
            scPrincipal.Panel2.Controls.Add(pCanvas);
            scPrincipal.Size = new Size(1384, 605);
            scPrincipal.SplitterDistance = 336;
            scPrincipal.TabIndex = 1;
            // 
            // scSuiteTraitements
            // 
            scSuiteTraitements.Dock = DockStyle.Fill;
            scSuiteTraitements.Location = new Point(0, 0);
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
            scSuiteTraitements.Size = new Size(336, 605);
            scSuiteTraitements.SplitterDistance = 296;
            scSuiteTraitements.TabIndex = 0;
            // 
            // lbSuiteTraitementAAppliquer
            // 
            lbSuiteTraitementAAppliquer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSuiteTraitementAAppliquer.FormattingEnabled = true;
            lbSuiteTraitementAAppliquer.ItemHeight = 20;
            lbSuiteTraitementAAppliquer.Location = new Point(3, 106);
            lbSuiteTraitementAAppliquer.Name = "lbSuiteTraitementAAppliquer";
            lbSuiteTraitementAAppliquer.Size = new Size(330, 124);
            lbSuiteTraitementAAppliquer.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(bAppliquerSuiteTraitement);
            panel1.Location = new Point(6, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 51);
            panel1.TabIndex = 1;
            // 
            // bAppliquerSuiteTraitement
            // 
            bAppliquerSuiteTraitement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bAppliquerSuiteTraitement.Location = new Point(0, 11);
            bAppliquerSuiteTraitement.Name = "bAppliquerSuiteTraitement";
            bAppliquerSuiteTraitement.Size = new Size(324, 29);
            bAppliquerSuiteTraitement.TabIndex = 0;
            bAppliquerSuiteTraitement.Text = "Appliquer";
            bAppliquerSuiteTraitement.UseVisualStyleBackColor = true;
            // 
            // pControlSuiteTraitements
            // 
            pControlSuiteTraitements.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pControlSuiteTraitements.Controls.Add(bSupprimerTraitement);
            pControlSuiteTraitements.Controls.Add(bAjouterTraitement);
            pControlSuiteTraitements.Controls.Add(bSuiteTraitementDeplacerBas);
            pControlSuiteTraitements.Controls.Add(bSuiteTraitementDeplacerHaut);
            pControlSuiteTraitements.Controls.Add(cbTraitementAAjouter);
            pControlSuiteTraitements.Location = new Point(3, 3);
            pControlSuiteTraitements.Name = "pControlSuiteTraitements";
            pControlSuiteTraitements.Size = new Size(330, 97);
            pControlSuiteTraitements.TabIndex = 0;
            // 
            // bSupprimerTraitement
            // 
            bSupprimerTraitement.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bSupprimerTraitement.Location = new Point(293, 56);
            bSupprimerTraitement.Name = "bSupprimerTraitement";
            bSupprimerTraitement.Size = new Size(32, 29);
            bSupprimerTraitement.TabIndex = 4;
            bSupprimerTraitement.Text = "-";
            bSupprimerTraitement.UseVisualStyleBackColor = true;
            // 
            // bAjouterTraitement
            // 
            bAjouterTraitement.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAjouterTraitement.Location = new Point(255, 56);
            bAjouterTraitement.Name = "bAjouterTraitement";
            bAjouterTraitement.Size = new Size(32, 29);
            bAjouterTraitement.TabIndex = 3;
            bAjouterTraitement.Text = "+";
            bAjouterTraitement.UseVisualStyleBackColor = true;
            // 
            // bSuiteTraitementDeplacerBas
            // 
            bSuiteTraitementDeplacerBas.Location = new Point(48, 56);
            bSuiteTraitementDeplacerBas.Name = "bSuiteTraitementDeplacerBas";
            bSuiteTraitementDeplacerBas.Size = new Size(33, 29);
            bSuiteTraitementDeplacerBas.TabIndex = 2;
            bSuiteTraitementDeplacerBas.Text = "v";
            bSuiteTraitementDeplacerBas.UseVisualStyleBackColor = true;
            // 
            // bSuiteTraitementDeplacerHaut
            // 
            bSuiteTraitementDeplacerHaut.Location = new Point(9, 56);
            bSuiteTraitementDeplacerHaut.Name = "bSuiteTraitementDeplacerHaut";
            bSuiteTraitementDeplacerHaut.Size = new Size(33, 29);
            bSuiteTraitementDeplacerHaut.TabIndex = 1;
            bSuiteTraitementDeplacerHaut.Text = "^";
            bSuiteTraitementDeplacerHaut.UseVisualStyleBackColor = true;
            // 
            // cbTraitementAAjouter
            // 
            cbTraitementAAjouter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTraitementAAjouter.FormattingEnabled = true;
            cbTraitementAAjouter.Location = new Point(3, 3);
            cbTraitementAAjouter.Name = "cbTraitementAAjouter";
            cbTraitementAAjouter.Size = new Size(324, 28);
            cbTraitementAAjouter.TabIndex = 0;
            // 
            // pgProprieteTraitementSelectionne
            // 
            pgProprieteTraitementSelectionne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pgProprieteTraitementSelectionne.Location = new Point(3, 3);
            pgProprieteTraitementSelectionne.Name = "pgProprieteTraitementSelectionne";
            pgProprieteTraitementSelectionne.Size = new Size(332, 290);
            pgProprieteTraitementSelectionne.TabIndex = 0;
            // 
            // pCanvas
            // 
            pCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pCanvas.Controls.Add(pbImage);
            pCanvas.Location = new Point(3, 3);
            pCanvas.Name = "pCanvas";
            pCanvas.Size = new Size(1038, 599);
            pCanvas.TabIndex = 0;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(3, 3);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(125, 62);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // fPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 633);
            Controls.Add(scPrincipal);
            Controls.Add(msPrincipal);
            MainMenuStrip = msPrincipal;
            MinimumSize = new Size(1402, 680);
            Name = "fPrincipale";
            Text = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msPrincipal;
        private ToolStripMenuItem fichierToolStripMenuItem;
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
    }
}