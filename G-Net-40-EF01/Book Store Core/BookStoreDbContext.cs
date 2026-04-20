using System;
using System.Collections.Generic;
using System.Text;
using G_Net_40_EF01.Models;
using Microsoft.EntityFrameworkCore;

namespace G_Net_40_EF01.Book_Store_Core
{
    public class BookStoreDbContext : DbContext
    {
        // Configure the database connection string and other options here
        #region Configure Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // configure the connection string to your database
            optionsBuilder.UseSqlServer("Server=.; Database= ReadMoreBooks; trusted_connection= True; trustservercertificate= True;");
        }
        #endregion

        // Define your DbSet properties for each entity here
        #region My DbSet
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        #endregion
    }
}
