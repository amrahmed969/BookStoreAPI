using ServiceStack.DataAnnotations;

namespace _1_API.Data.Models
{
    public class Books
    {
        
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime ? DateRead { get; set; }
        public int ? Rate { get; set; }
        public string CoverUrl { get; set; }
        public string Genre { get; set; }
        public DateTime DateAdded { get; set; }

        public int  PublisherId { get; set; }
        public Publisher publisher { get; set; }

        public List<Books_Author> books_Authors { get; set; }


    }
}
