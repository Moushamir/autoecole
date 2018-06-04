using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoecoleconsole
{
    class Eleve
    {
        private int id;
        private String nom;
        private DateTime dateInscription;
        private String prenom;
        private String adresse;
        private Lecon lecons;


        public Eleve(int idEleve, String nomE, DateTime dateIns, String prenomE, String adresseE)
        {
            this.id = idEleve;
            this.nom = nomE;
            this.dateInscription = dateIns;
            this.prenom = prenomE;
            this.adresse = adresseE;
        }


        public int getIdEleve()
        {
            return id;

        }

        public void setIdEleve(int idE)
        {
            this.id = idE;
        }

        public String getNomEleve()
        {
            return nom;

        }

        public void setNomEleve(String nomE)
        {
            this.nom = nomE;
        }

        public String getPrenomEleve()
        {
            return prenom;

        }

        public void setPreomEleve(String prenomE)
        {
            this.prenom = prenomE;
        }


        public String getAdresseEleve()
        {
            return adresse;

        }

        public void setAdresseEleve(String adresseE)
        {
            this.prenom = adresseE;
        }




    }
}
