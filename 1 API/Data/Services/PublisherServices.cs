using _1_API.Data.Models;
using _1_API.Data.ViewModels;

namespace _1_API.Data.Services
{
    public class PublisherServices
    {
        #region DI _context
        private AppDbContext _context;
        public PublisherServices(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name,
            };

            _context.publishers.Add(_publisher);
            _context.SaveChanges();
        }



        public PublisherwithBookAndAutherVM GetpublisherData(int publisherid)
        {
            var _publiserdata = _context.publishers.Where(x => x.Id == publisherid)
                .Select(n => new PublisherwithBookAndAutherVM()
                {
                    publisherName = n.Name,

                    BookAuthorsVMs = n.books.Select(y => new BookAuthorsVM
                    {

                        BookName = y.Title,
                        AuthorsName = y.books_Authors.Select(z => z.Author.FullName).ToList()
                    }).ToList()


                }).FirstOrDefault();
            return _publiserdata;
            
        }

        public void DeletePublisherById(int id)
        {
            var _Publisher = _context.publishers.FirstOrDefault(x => x.Id == id);
            if(_Publisher != null)
            {
                _context.publishers.Remove(_Publisher);
                _context.SaveChanges();
            }
        }
    }
}

