using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataPiratesTeam.Models;

    public class RazorPagesInfoSContext : DbContext
    {
        public RazorPagesInfoSContext (DbContextOptions<RazorPagesInfoSContext> options)
            : base(options)
        {
        }

        public DbSet<DataPiratesTeam.Models.InfoS> InfoS { get; set; }
    }
