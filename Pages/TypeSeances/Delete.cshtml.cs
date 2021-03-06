﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetEmploi.Models;

namespace ProjetEmploi.Pages.TypeSeances
{
    public class DeleteModel : PageModel
    {
        private readonly ProjetEmploi.Models.ProjetEmploiContext _context;

        public DeleteModel(ProjetEmploi.Models.ProjetEmploiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TypeSeance TypeSeance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypeSeance = await _context.TypeSeance.FirstOrDefaultAsync(m => m.ID == id);

            if (TypeSeance == null)
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

            TypeSeance = await _context.TypeSeance.FindAsync(id);

            if (TypeSeance != null)
            {
                _context.TypeSeance.Remove(TypeSeance);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
