using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetEmploi.Models
{
    public class Seance
    {
        //Clé Primaire
        public int ID { get; set; }

        [Display(Name = "Jour")]
        [DataType(DataType.Date)]
        public DateTime Jour { get; set; }

        //[Required]
        [Display(Name = "Heure Début")]
        [DataType(DataType.Time)]
        public DateTime HeureDebut { get; set; }

        //[Required]
        public int Duree { get; set; }

        // Clé étrangère vers l'UE
        public int UEID { get; set; }

        // Clé étrangère vers le type de séance
        public int TypeSeanceID { get; set; }
        /*public enum EnumIntitule
        {
            CM, TD, TP
        }*/

        //Clé étrangère vers la salle
        public int SalleID { get; set; }

        //Clé étrangère vers le groupe
        public int GroupeID { get; set; }


        //Liens de navigations
        [Display(Name = "UE")]
        public UE LUE { get; set; }

        [Display(Name = "Type séance")]
        public TypeSeance LeTypeSeance { get; set; }

        [Display(Name = "Salle")]
        public Salle LaSalle { get; set; }

        [Display(Name = "Groupe")]
        public Groupe LeGroupe { get; set; }
    }
}
