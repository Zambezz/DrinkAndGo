using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DrinkAndGo.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DrinkAndGo.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
	{
	    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
	    {
	    }
	    public DbSet<Drink> Drinks { get; set; }
	    public DbSet<Category> Categories { get; set; }
		public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
	}
}
