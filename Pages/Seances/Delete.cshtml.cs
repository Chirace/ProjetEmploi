﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetEmploi.Models;

namespace ProjetEmploi.Pages.Seances
{
    public class DeleteModel : PageModel
    {
        private readonly ProjetEmploi.Models.ProjetEmploiContext _context;

        public DeleteModel(ProjetEmploi.Models.ProjetEmploiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Seance Seance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seance = await _context.Seance
                .Include(s => s.LUE)
                .Include(s => s.LaSalle)
                .Include(s => s.LeGroupe)
                .Include(s => s.LeTypeSeance).FirstOrDefaultAsync(m => m.ID == id);

            if (Seance == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seance = await _context.Seance.FindAsync(id);

            if (Seance != null)
            {
                _context.Seance.Remove(Seance);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
