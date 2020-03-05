using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetEmploi.Models
{
    public class Salle
    {
        //Clé Primaire
        public int ID { get; set; }
        //[Required]
        public String Nom { get; set; }

        [Display(Name = "Salle")]

        //Clé étrangère du bâtiment
        public int BatimentID { get; set; }

        //Liens de navigations
        //[Required]
        public Batiment LeBatiment { get; set; }
    }
}
