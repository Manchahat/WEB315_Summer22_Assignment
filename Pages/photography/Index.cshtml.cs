using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB315_Summer22_Assignment.Models;

namespace WEB315_Summer22_Assignment.Pages_photography
{
    public class IndexModel : PageModel
    {
        private readonly WEB315_Summer22_AssignmentContext _context;

        public IndexModel(WEB315_Summer22_AssignmentContext context)
        {
            _context = context;
        }

        public IList<photography> photography { get;set; }

        public async Task OnGetAsync()
        {
            photography = await _context.photography.ToListAsync();
        }
    }
}
