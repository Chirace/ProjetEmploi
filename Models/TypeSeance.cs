using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetEmploi.Models
{
    public class TypeSeance
    {
        public enum EnumIntitule
        {
            CM, TD, TP
        }
        //Clé Primaire
        public int ID { get; set; }

        //[Required]
        public EnumIntitule Intitule { get; set; }
    }
}
