using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module12_TraitementImages
{
    [Description("Diminuer le bruit")]
    public class TraitementImageDiminuerBruit : TraitementImageMasque
    {
        public TraitementImageDiminuerBruit()
        {
            ;
        }

        private static byte TraiterDonnees(byte[] p_donnees)
        {
            Array.Sort(p_donnees);

            return p_donnees[p_donnees.Length / 2];
        }

        public override string ToString()
        {
            return UtilitaireTraitements.DescriptionTraitement(this);
        }
    }
}
