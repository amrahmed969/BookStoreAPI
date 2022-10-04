namespace _1_API.Data.Models
{
    public class Books_Author
    {
        public int Id { get; set; }

        public int Bookid { get; set; }
        public Books Books { get; set; }

        public int Authorid { get; set; }
        public Author Author { get; set; }
    }
}
