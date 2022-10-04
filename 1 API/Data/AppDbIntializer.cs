//using _1_API.Data.Models;

//namespace _1_API.Data
//{
//    public class AppDbIntializer
//    {
//        public static void Seed(IApplicationBuilder applicationBuilder)
//        {
//            using (var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
//            {
//                var context = ServiceScope.ServiceProvider.GetService<AppDbContext>();

//                if (!context.Books.Any())
//                {
//                    context.AddRange(new Books()
//                    {
//                        Title = "firstbook",
//                        Description = "firstdiscription",
//                        CoverUrl = "https...",
//                        DateAdded = DateTime.Now.AddDays(1),
//                        DateRead = DateTime.Now,
//                        Genre = "comedy",
//                        IsRead = true,
//                        Rate = 6

//                    },
//                    new Books()
//                    {
//                        Title = "secondtbook",
//                        Description = "firstdiscription",
//                        CoverUrl = "https...",
//                        DateAdded = DateTime.Now.AddDays(1),
//                        Genre = "comedy",
//                        IsRead = false


//                    });

//                    context.SaveChanges();
//                }
//            }
//        }
//    }
//}
