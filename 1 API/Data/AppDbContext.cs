using _1_API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace _1_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books_Author>().HasOne(a => a.Books).WithMany(b =>b.books_Authors).HasForeignKey(c=>c.Bookid);
            modelBuilder.Entity<Books_Author>().HasOne(a => a.Author).WithMany(b =>b.books_Authors).HasForeignKey(c=>c.Authorid);
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Author> Authors  { get; set; }
        public DbSet<Publisher> publishers { get; set; }
        public DbSet<Books_Author> Author_books { get; set; }

          
           




        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Books>().HasData(new Books
        //    {
        //        ID = 1,
        //        Title = "firstbook",
        //        Description = "firstdiscription",
        //        CoverUrl = "https...",
        //        DateAdded = DateTime.Now.AddDays(1),
        //        DateRead = DateTime.Now,
        //        Genre = "comedy",
        //        IsRead = true,
        //        Rate = 6
        //    },
        //    new Books
        //    {
        //        ID = 2,
        //        Title = "secondbook",
        //        Description = "firstdiscription",
        //        CoverUrl = "https...",
        //        DateAdded = DateTime.Now.AddDays(1),
        //        DateRead = DateTime.Now,
        //        Genre = "comedy",
        //        IsRead = true,
        //        Rate = 6
        //    },
        //     new Books
        //     {
        //        ID= 3,
        //         Title = "Thirdbook",
        //         Description = "Thirdiscription",
        //         CoverUrl = "https...",
        //         DateAdded = DateTime.Now.AddDays(1),
        //         DateRead = DateTime.Now,
        //         Genre = "action",
        //         IsRead = true,
        //         Rate = 4
        //     }
        //        );
        //}

        
    }

}
