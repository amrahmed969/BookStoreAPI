using _1_API.Data.Models;
using _1_API.Data.ViewModels;

namespace _1_API.Data.Services
{
    public class AuthorServices
    {
        #region DI _context
        private AppDbContext _context;
        public AuthorServices(AppDbContext context)
        {
            _context = context;
        }
        #endregion


        public void AddAuther(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName,
            };

            _context.Authors.Add(_author);
            _context.SaveChanges();
        }


        public AuthorwithBookVM GetAutrorwithBookVM (int authorid)
        {
            var _author = _context.Authors.Where(x => x.Id == authorid)
                .Select(y => new AuthorwithBookVM
                {
               FullName = y.FullName,
                BookTitle = y.books_Authors.Select(z => z.Books.Title).ToList()
                
                }).FirstOrDefault();



            return _author;
        }     


    }
}
