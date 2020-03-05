using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetEmploi.Models;

namespace ProjetEmploi.Models
{
    public class ProjetEmploiContext : DbContext
    {
        public ProjetEmploiContext (DbContextOptions<ProjetEmploiContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetEmploi.Models.Batiment> Batiment { get; set; }

        public DbSet<ProjetEmploi.Models.Groupe> Groupe { get; set; }

        public DbSet<ProjetEmploi.Models.Salle> Salle { get; set; }

        public DbSet<ProjetEmploi.Models.Seance> Seance { get; set; }

        public DbSet<ProjetEmploi.Models.TypeSeance> TypeSeance { get; set; }

        public DbSet<ProjetEmploi.Models.UE> UE { get; set; }
    }
}
