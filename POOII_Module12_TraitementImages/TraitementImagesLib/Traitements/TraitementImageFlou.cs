using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module12_TraitementImages
{
    [Description("Flou")]
    public class TraitementImageFlou : TraitementImageMasque
    {
        public TraitementImageFlou(int p_largeur, Func<byte[], byte> p_transformation) : 
            base(p_largeur, p_transformation)
        {
            ;
        }

        private static byte TraiterDonnees(byte[] p_donnees)
        {
            int somme = 0;
            for (int i = 0; i < p_donnees.Length; i++)
            {
                somme += p_donnees[i];
            }

            return (byte)(somme / p_donnees.Length);
        }

        public override string ToString()
        {
            return "Flou";
        }
    }
}
