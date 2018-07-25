using Microsoft.EntityFrameworkCore;
using ShoppingCartAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartAPI.Database
{
    /// <summary>
    /// Handles database facilitations
    /// </summary>
    public class CartDbContext: DbContext
    {

        public CartDbContext(DbContextOptions<CartDbContext> options) : base(options){
            base.Database.EnsureCreated(); 
           
        }

        public DbSet<Cart>CartItems { get; set; }
        public DbSet<Item>Items { get; set; }

        

    }
}
