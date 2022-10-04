using _1_API.Data.Models;
using _1_API.Data.ViewModels;

namespace _1_API.Data.Services
{
    public class BookServices
    {
        #region DI _context
        private AppDbContext _context;
        public BookServices(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        //add new book
        public void AddBooksWithAuthor(BookVM book)
        {
            var _book = new Books()
            {
                
                IsRead = book.IsRead,                 
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Description = book.Description,
                CoverUrl = book.CoverUrl,
                Genre = book.Genre,
                Title = book.Title,
                Rate = book.IsRead ? book.Rate.Value : null,
                PublisherId = book.PublisherId,
                
                
            };

            _context.Books.Add(_book);
            _context.SaveChanges();


            foreach(var Id  in book.AuthorIds)
            {
                var _book_Author = new Books_Author()
                {
                   Bookid = _book.ID,
                    Authorid = Id
                };
                _context.Author_books.Add(_book_Author);
                _context.SaveChanges();
            }



        }


        ////get books

        //public List<Books> GetBooks()
        //{
        //    var books = _context.Books.ToList();
        //    return books;

        //}
        ////get books by id

        //public Books GetBookById(int id)
        //{
        //    var bookid = _context.Books.FirstOrDefault(x => x.ID == id);
        //    return bookid;
        //}

        //****************************************************************************

        //get books

        public List<Books> GetBooks()
        {
            var books = _context.Books.ToList();
            return books;

        }
        //get books by id

        public BookwithAuthorVM GetBookById1(int id)
        {
            var _bookwithauthor = _context.Books.Where(x => x.ID == id).Select(book => new BookwithAuthorVM
            {
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Description = book.Description,
                CoverUrl = book.CoverUrl,
                Genre = book.Genre,
                Title = book.Title,
                Rate = book.IsRead ? book.Rate.Value : null,
                PublisherName = book.publisher.Name,
                AuthorsName = book.books_Authors.Select(x => x.Author.FullName).ToList(),
            }).FirstOrDefault();

            return _bookwithauthor;
        
        }

        //********************************************************************************
        //get books by id

        public Books GetBookById(int id)
        {
            var bookid = _context.Books.FirstOrDefault(x => x.ID == id);
            return bookid;
        }


        //*********************************************************************************

        // updating books 
        public Books UpdateBooks(int id , BookVM book)
        {
            //var _book = GetBookById(id);

            var _book = _context.Books.FirstOrDefault(x => x.ID == id);
            

            if (_book != null)
            {
                _book.IsRead = book.IsRead;
                _book.DateRead = book.IsRead ? book.DateRead.Value : null;
                _book.Description = book.Description;
                _book.CoverUrl = book.CoverUrl;
                _book.Genre = book.Genre;
                _book.Title = book.Title;
                _book.Rate = book.IsRead ? book.Rate.Value : null;
                _context.SaveChanges();
            }
            return _book;
        }


        //deleting

        public void Deleting(int id)
        {
            var bookid = GetBookById(id); 
            if(bookid != null)
            {
                _context.Books.Remove(bookid);
                _context.SaveChanges();
                
            }
        }

    }
}
