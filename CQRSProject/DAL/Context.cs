using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace CQRSProject.DAL;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=DESKTOP-A6C5CRN\\MSSQLSERVER01;initial Catalog=DbCqrs;integrated Security=true;Trust Server Certificate=true;");
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}