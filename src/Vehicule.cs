using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoecoleconsole
{
    class Vehicule
    {

        private String numImma;
        private String modele;
        private String couleur;
        private Lecon lecons;


        public Vehicule(String imma, String mdl, String clr)
        {
            this.numImma = imma;
            this.modele = mdl;
            this.couleur = clr;
        }





        public String getImmatriculation()
        {
            return numImma;

        }
      
        public void setImmatriculation(String numImma)
        {
            this.numImma = numImma;
        }

        public String getModele()
        {
            return modele;

        }

        public void setModele(String modele)
        {
            this.modele = modele;
        }

        public String getCouleur()
        {
            return couleur;

        }

        public void setCouleur(String couleur)
        {
            this.couleur = couleur;
        }

    }
}
