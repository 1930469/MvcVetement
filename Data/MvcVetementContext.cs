using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcVetement.Models;

namespace MvcVetement.Data
{
    public class MvcVetementContext : IdentityDbContext
    {
        public MvcVetementContext(DbContextOptions<MvcVetementContext> options)
                : base(options)
        {
        }
        public DbSet<Vetement> Vetement { get; set; }
    }
}
