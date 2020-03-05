using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetEmploi.Models;

namespace ProjetEmploi.Pages.Seances
{
    public class IndexModel : PageModel
    {
        private readonly ProjetEmploi.Models.ProjetEmploiContext _context;

        public IndexModel(ProjetEmploi.Models.ProjetEmploiContext context)
        {
            _context = context;
        }

        public IList<Seance> Seance { get;set; }

        public async Task OnGetAsync()
        {
            Seance = await _context.Seance
                .Include(s => s.LUE)
                .Include(s => s.LaSalle)
                .Include(s => s.LeGroupe)
                .Include(s => s.LeTypeSeance).ToListAsync();
        }
    }
}
