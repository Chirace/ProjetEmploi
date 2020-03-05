using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetEmploi.Models;

namespace ProjetEmploi.Pages.Batiments
{
    public class IndexModel : PageModel
    {
        private readonly ProjetEmploi.Models.ProjetEmploiContext _context;

        public IndexModel(ProjetEmploi.Models.ProjetEmploiContext context)
        {
            _context = context;
        }

        public IList<Batiment> Batiment { get;set; }

        public async Task OnGetAsync()
        {
            Batiment = await _context.Batiment.ToListAsync();
        }
    }
}
