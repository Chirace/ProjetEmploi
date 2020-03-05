using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetEmploi.Models
{
    public class Groupe
    {
        //Clé Primaire
        public int ID { get; set; }
        //[Required]
        public String Nom { get; set; }
    }
}
