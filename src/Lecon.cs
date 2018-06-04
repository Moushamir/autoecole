using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoecoleconsole
{
    class Lecon
    {

        private int id;
        private DateTime date;
        
        private int duree;
        private bool effectueeOui_Non;
        private Eleve eleve;
        private Vehicule numImmaVehicule;


        public Lecon(int idLecon, DateTime dateLecon, Eleve eleve, int dureeLecon, bool effectue, Vehicule imma)
        {
            this.id = idLecon;
            this.date = dateLecon;
            this.eleve = eleve;
            this.duree = dureeLecon;
            this.effectueeOui_Non = effectue;
            this.numImmaVehicule = imma;
        }


        public int getId()
        {
            return id;

        }

        public void setId(int id)
        {
            this.id = id;
        }

       
        public DateTime getDate()
        {
            return date;

        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }


        public int getDuree()
        {
            return duree;

        }

        public void setDuree(int duree)
        {
            this.duree = duree;
        }


        public bool geteffectueeOui_Non()
        {
            return effectueeOui_Non;

        }

        public void setEffectueeOui_Non(bool effectue)
        {
            this.effectueeOui_Non = effectue;
        }

       

    }
}
