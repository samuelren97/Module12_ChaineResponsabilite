namespace POOII_Module12_TraitementImages
{
    public partial class fPrincipale : Form
    {
        private ImageManipulable m_imageManipulable;
        private List<ITraitementImage> m_suiteTraitementImage;

        public fPrincipale()
        {
            InitializeComponent();
        }

        private void fPrincipale_Load(object sender, EventArgs e)
        {
            cbTraitementAAjouter.DataSource = UtilitaireTraitements.RechercherTraitementsImage().ToList();

            this.m_suiteTraitementImage = new List<ITraitementImage>();
            lbSuiteTraitementAAppliquer.DataSource = this.m_suiteTraitementImage;
        }

        private void tsfmiOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers JPEG|*.jpg;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                m_imageManipulable = new ImageManipulable(ofd.FileName);
                pbImage.Image = m_imageManipulable.Image;
            }
        }

        private void bSuiteTraitementDeplacerHaut_Click(object sender, EventArgs e)
        {
            int indiceChoisi = this.lbSuiteTraitementAAppliquer.SelectedIndex;
            if (indiceChoisi > 0)
            {
                ITraitementImage tmpTraitement = this.m_suiteTraitementImage[indiceChoisi];
                this.m_suiteTraitementImage[indiceChoisi] = this.m_suiteTraitementImage[indiceChoisi - 1];
                this.m_suiteTraitementImage[indiceChoisi - 1] = tmpTraitement;
                MettreAJourListBox();
                this.lbSuiteTraitementAAppliquer.SelectedIndex = indiceChoisi - 1;
            }
        }

        private void bSuiteTraitementDeplacerBas_Click(object sender, EventArgs e)
        {
            int indiceChoisi = this.lbSuiteTraitementAAppliquer.SelectedIndex;
            if (indiceChoisi != -1 && indiceChoisi < this.m_suiteTraitementImage.Count - 1)
            {
                ITraitementImage tmpTraitement = this.m_suiteTraitementImage[indiceChoisi];
                this.m_suiteTraitementImage[indiceChoisi] = this.m_suiteTraitementImage[indiceChoisi + 1];
                this.m_suiteTraitementImage[indiceChoisi + 1] = tmpTraitement;
                MettreAJourListBox();
                this.lbSuiteTraitementAAppliquer.SelectedIndex = indiceChoisi + 1;
            }
        }

        private void bAjouterTraitement_Click(object sender, EventArgs e)
        {
            CreateurTraitement createurTraitement = (CreateurTraitement)this.cbTraitementAAjouter.SelectedItem;
            this.m_suiteTraitementImage.Add(createurTraitement.Creer());
            MettreAJourListBox();
        }

        private void bSupprimerTraitement_Click(object sender, EventArgs e)
        {
            if (this.lbSuiteTraitementAAppliquer.SelectedIndex != -1)
            {
                this.m_suiteTraitementImage.RemoveAt(this.lbSuiteTraitementAAppliquer.SelectedIndex);
                MettreAJourListBox();
            }
        }

        private void MettreAJourListBox()
        {
            lbSuiteTraitementAAppliquer.DataSource = null;
            lbSuiteTraitementAAppliquer.DataSource = this.m_suiteTraitementImage;
            lbSuiteTraitementAAppliquer.Refresh();
        }

        private void lbSuiteTraitementAAppliquer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbSuiteTraitementAAppliquer.SelectedIndex != -1)
            {
                pgProprieteTraitementSelectionne.SelectedObject = this.m_suiteTraitementImage[lbSuiteTraitementAAppliquer.SelectedIndex];
            }
        }

        private void bAppliquerSuiteTraitement_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.m_suiteTraitementImage.Count-2; i++)
            {
                this.m_suiteTraitementImage[i].Suivant = this.m_suiteTraitementImage[i + 1];
            }

            this.m_suiteTraitementImage[0].TraiterImage(m_imageManipulable);
        }
    }
}