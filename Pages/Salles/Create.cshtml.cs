using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetEmploi.Models;

namespace ProjetEmploi.Pages.Salles
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
        ViewData["BatimentID"] = new SelectList(_context.Batiment, "ID", "Nom");
            return Page();
        }

        [BindProperty]
        public Salle Salle { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Salle.Add(Salle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
