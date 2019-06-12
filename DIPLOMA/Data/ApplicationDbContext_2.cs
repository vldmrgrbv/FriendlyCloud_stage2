using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIPLOMA.Models;
using Microsoft.EntityFrameworkCore;

namespace DIPLOMA.Data
{
    public class ApplicationDbContext_2 : DbContext
    {
        public ApplicationDbContext_2(DbContextOptions<ApplicationDbContext_2> options) : base(options)
        {
        }

        public DbSet<DirectoryClients> Clients { get; set; }
        public DbSet<DirectoryEmployees> Employees { get; set; }
        public DbSet<DirectoryServices> Services { get; set; }
    }
}
