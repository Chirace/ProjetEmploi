﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetEmploi.Models;

namespace ProjetEmploi.Pages.Groupes
{
    public class EditModel : PageModel
    {
        private readonly ProjetEmploi.Models.ProjetEmploiContext _context;

        public EditModel(ProjetEmploi.Models.ProjetEmploiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Groupe Groupe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Groupe = await _context.Groupe.FirstOrDefaultAsync(m => m.ID == id);

            if (Groupe == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Groupe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupeExists(Groupe.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GroupeExists(int id)
        {
            return _context.Groupe.Any(e => e.ID == id);
        }
    }
}
