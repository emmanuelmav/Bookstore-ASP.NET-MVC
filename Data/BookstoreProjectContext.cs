using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookstoreProject.Models;

namespace BookstoreProject.Data
{
    public class BookstoreProjectContext : DbContext
    {
        public BookstoreProjectContext (DbContextOptions<BookstoreProjectContext> options)
            : base(options)
        {
        }

        public DbSet<BookstoreProject.Models.Book> Book { get; set; } = default!;
    }
}
