using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataPiratesTeam.Models;

namespace DataPiratesTeam.Pages.InfoSs
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesInfoSContext _context;

        public DeleteModel(RazorPagesInfoSContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InfoS = await _context.InfoS.FindAsync(id);

            if (InfoS != null)
            {
                _context.InfoS.Remove(InfoS);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
