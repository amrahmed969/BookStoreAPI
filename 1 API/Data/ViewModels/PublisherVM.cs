namespace _1_API.Data.ViewModels
{
    public class PublisherVM
    {
        public string Name { get; set; }
    }


    public class PublisherwithBookAndAutherVM
    {
        public string publisherName { get; set; }
        public List<BookAuthorsVM> BookAuthorsVMs { get; set; }
    }

    public class BookAuthorsVM
    {
        public string BookName { get; set; }
        public List<string> AuthorsName { get; set; }
    }
}
