using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB315_Summer22_Assignment.Models;

namespace WEB315_Summer22_Assignment.Pages_photography
{
    public class CreateModel : PageModel
    {
        private readonly WEB315_Summer22_AssignmentContext _context;

        public CreateModel(WEB315_Summer22_AssignmentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public photography photography { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.photography.Add(photography);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
