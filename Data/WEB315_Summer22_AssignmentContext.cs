using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEB315_Summer22_Assignment.Models;

    public class WEB315_Summer22_AssignmentContext : DbContext
    {
        public WEB315_Summer22_AssignmentContext (DbContextOptions<WEB315_Summer22_AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<WEB315_Summer22_Assignment.Models.photography> photography { get; set; }
    }
