using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marc_Loredana_Lab8.Data;
using Marc_Loredana_Lab8.Models;

namespace Marc_Loredana_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Marc_Loredana_Lab8.Data.Marc_Loredana_Lab8Context _context;

        public IndexModel(Marc_Loredana_Lab8.Data.Marc_Loredana_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
