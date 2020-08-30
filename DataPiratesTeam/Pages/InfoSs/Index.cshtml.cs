using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataPiratesTeam.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DataPiratesTeam.Pages.InfoSs
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesInfoSContext _context;

        public IndexModel(RazorPagesInfoSContext context)
        {
            _context = context;
        }

        public IList<InfoS> InfoS { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Degrees { get; set; }
        [BindProperty(SupportsGet = true)]
        public string InfoSDegree { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> degreeQuery = from i in _context.InfoS
                                            orderby i.Degree
                                            select i.Degree;

            var interest = from i in _context.InfoS
                         select i;
            if (!string.IsNullOrEmpty(SearchString))
            {
                interest = interest.Where(s => s.Interest.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(InfoSDegree))
            {
                interest = interest.Where(s => s.Degree == InfoSDegree);
            }

            Degrees = new SelectList(await degreeQuery.Distinct().ToListAsync());
            InfoS = await interest.ToListAsync();
        }
    }
}
