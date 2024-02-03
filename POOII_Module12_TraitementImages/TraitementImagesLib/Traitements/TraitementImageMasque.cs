using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module12_TraitementImages
{
    [Description("Masque")]
    public class TraitementImageMasque : ITraitementImage
    {
        public ITraitementImage? Suivant { get; set; }

        private int m_largeur;
        public int Largeur
        {
            get 
            { 
                return m_largeur;
            }
            set 
            {
                if ((value & 1) == 0) // pair
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), "La largeur doit être impaire");
                }
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), "La largeur doit être supérieure à 0");
                }
                this.m_largeur = value; 
            }
        }

        private Func<byte[], byte> m_transformation;

        public TraitementImageMasque(int p_largeur, Func<byte[], byte> p_transformation)
        {
            if (p_transformation is null)
            {
                throw new ArgumentNullException(
                    nameof(p_transformation), "La fonction de transformation ne peut pas être null");
            }
            this.Largeur = p_largeur;
            this.m_transformation = p_transformation;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void TraiterImage(ImageManipulable p_image)
        {
            byte[] raw = p_image.Raw;
            byte[] res = new byte[raw.Length];
            int width = p_image.Width;
            int height = p_image.Height;
            int stride = p_image.Stride;
            byte[] donneesCourantes = new byte[this.Largeur * this.Largeur];
            for (int colonne = 0; colonne < width; colonne++)
            {
                for (int ligne = 0; ligne < height; ligne++)
                {
                    for (int composante = 0; composante < 3; composante++)
                    {
                        int posDonneesCourantes = 0;
                        for (int masqueX = -this.Largeur / 2; masqueX <= this.Largeur / 2; masqueX++)
                        {
                            int posX = Math.Min(Math.Max(0, colonne + masqueX), width - 1);
                            for (int masqueY = -this.Largeur / 2; masqueY <= this.Largeur / 2; masqueY++)
                            {
                                int posY = Math.Min(Math.Max(0, ligne + masqueY), height - 1);
                                donneesCourantes[posDonneesCourantes] = raw[posY * stride + posX * 3 + composante];
                                ++posDonneesCourantes;
                            }
                        }
                        res[ligne * stride + colonne * 3 + composante] = this.Transformation(donneesCourantes);
                    }
                }
            }

            Array.Copy(res, raw, raw.Length);

            this.Suivant?.TraiterImage(p_image);
        }

        public override string ToString()
        {
            return "Masque";
        }
    }
}
