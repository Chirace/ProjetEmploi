using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetEmploi.Models;

namespace ProjetEmploi.Pages.Seances
{
    public class CreateModel : PageModel
    {
        private readonly ProjetEmploi.Models.ProjetEmploiContext _context;

        public CreateModel(ProjetEmploi.Models.ProjetEmploiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UEID"] = new SelectList(_context.Set<UE>(), "ID", "NomComplet");
        ViewData["SalleID"] = new SelectList(_context.Salle, "ID", "ID");
        ViewData["GroupeID"] = new SelectList(_context.Groupe, "ID", "Nom");
        ViewData["TypeSeanceID"] = new SelectList(_context.Set<TypeSeance>(), "ID", "Intitule");
            return Page();
        }

        [BindProperty]
        public Seance Seance { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Seance.Add(Seance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
