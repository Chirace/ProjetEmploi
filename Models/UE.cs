using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetEmploi.Models
{
    public class UE
    {
        //Clé Primaire
        public int ID { get; set; }
        //[Required]
        public String Numero { get; set; }
        //[Required]
        public String Intitule { get; set; }

        public string NomComplet
        {
            get
            {
                return Numero + " - " + Intitule;
            }
        }

        //Liens de navigation
        //public ICollection<Groupe> LesGroupes { get; set; }
        //public ICollection<Seance> LesSeances { get; set; }
    }
}
