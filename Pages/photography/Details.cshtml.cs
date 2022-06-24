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
    public class DetailsModel : PageModel
    {
        private readonly WEB315_Summer22_AssignmentContext _context;

        public DetailsModel(WEB315_Summer22_AssignmentContext context)
        {
            _context = context;
        }

        public photography photography { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            photography = await _context.photography.FirstOrDefaultAsync(m => m.ID == id);

            if (photography == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
