namespace _1_API.Data.Models
{
    public class Author
    {
        public int Id { get; set; } 
        public string FullName { get; set; }



        public List<Books_Author> books_Authors { get; set; }
    }

}
