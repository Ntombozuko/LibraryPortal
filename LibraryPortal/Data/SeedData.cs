using LibraryPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryPortal.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryPortalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LibraryPortalContext>>()))
            {
                // Look for any books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }
                context.Book.AddRange(
                    new Book
                    {
                        Picture = "~/images/toKill215324044.jpg",
                        Title = "To kill a mocking bird",
                        ISBN = "0788095236881",
                        Category = "Southern Gothic",
                        PageCount = 281,
                        Publisher = "J.B Lippincott & Co",
                        YearPublished = DateTime.Parse("1960-07-11"),
                        Takealot = "https://www.takealot.com/to-kill-a-mockingbird/PLID38666341",
                        Amazon = "https://www.amazon.com/Kill-Mockingbird-Harper-Lee/dp/0446310786"
                    },
                    new Book
                    {
                        Picture = "~/images/Romeo213611409.jpg",
                        Title = "The color purple",
                        ISBN = "9780143135692",
                        Category = "Epistolary",
                        PageCount = 304,
                        Publisher = "Penguin Publishing group",
                        YearPublished = DateTime.Parse("2019-10-12"),
                        Takealot = "https://www.takealot.com/the-color-purple/PLID44463079",
                        Amazon = "https://www.amazon.com/Color-Purple-Alice-Walker/dp/1780228716"
                    },
                    new Book
                    {
                        Picture = "~/images/BookThief212104208.jpg",
                        Title = "The book thief",
                        ISBN = "9780375842207",
                        Category = "Historical fiction",
                        PageCount = 584,
                        Publisher = "Knof books for young readers",
                        YearPublished = DateTime.Parse("2007-09-11"),
                        Takealot = "https://www.takealot.com/the-book-thief/PLID34639233",
                        Amazon = "https://www.amazon.com/Book-Thief-Markus-Zusak/dp/0375842209"
                    }
                );
                context.SaveChanges();

                // Look for any Authors.
                if (context.Author.Any())
                {
                    return;   // DB has been seeded
                }
                context.Author.AddRange(
                    new Author { Name = "Harper", Surname = "Lee" },
                    new Author { Name = "Alice", Surname = "Walker" },
                    new Author { Name = "Markus", Surname = "Zusak" }
                );
                context.SaveChanges();
            }
        }
    }
}
