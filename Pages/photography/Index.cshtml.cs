using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Types { get; set; }
        [BindProperty(SupportsGet = true)]
        public string photographyTypes { get; set; }

        public async Task OnGetAsync()
        {
        IQueryable<string> TypesQuery = from p in _context.photography
                                orderby p.Type
                                select p.Type;

        var photographys = from p in _context.photography
                select p;

            if (!string.IsNullOrEmpty(SearchString))
            {
                photographys = photographys.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(photographyTypes))
            {
                photographys = photographys.Where(x => x.Type == photographyTypes);
            }
            Types = new SelectList(await TypesQuery.Distinct().ToListAsync());
            photography = await photographys.ToListAsync();
        }
        
    }
}
