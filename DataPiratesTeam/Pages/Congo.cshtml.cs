using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DataPiratesTeam.Pages
{
    public class CongoModel : PageModel
    {
        private readonly ILogger<CongoModel> _logger;

        public CongoModel(ILogger<CongoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
