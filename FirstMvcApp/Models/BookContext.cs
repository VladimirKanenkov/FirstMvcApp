using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace FirstMvcApp.Models
{
    public class BookContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}