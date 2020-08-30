using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataPiratesTeam.Models;

namespace DataPiratesTeam.Pages.InfoSs
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesInfoSContext _context;

        public EditModel(RazorPagesInfoSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InfoS InfoS { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InfoS = await _context.InfoS.FirstOrDefaultAsync(m => m.ID == id);

            if (InfoS == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(InfoS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfoSExists(InfoS.ID))
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

        private bool InfoSExists(int id)
        {
            return _context.InfoS.Any(e => e.ID == id);
        }
    }
}
