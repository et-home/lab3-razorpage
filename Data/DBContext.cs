#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using lab3.Models;


public class DBContext : IdentityDbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public DbSet<lab3.Models.Product> Product { get; set; }

    public DbSet<lab3.Models.User> User { get; set; }
}

