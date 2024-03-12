using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryPortal.Models;

namespace LibraryPortal.Data
{
    public class LibraryPortalContext : DbContext
    {
        public LibraryPortalContext (DbContextOptions<LibraryPortalContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryPortal.Models.Book> Book { get; set; } = default!;

        public DbSet<LibraryPortal.Models.Author> Author { get; set; } = default!;
    }
}
