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
    public class DeleteModel : PageModel
    {
        private readonly WEB315_Summer22_AssignmentContext _context;

        public DeleteModel(WEB315_Summer22_AssignmentContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            photography = await _context.photography.FindAsync(id);

            if (photography != null)
            {
                _context.photography.Remove(photography);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
