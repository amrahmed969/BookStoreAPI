namespace _1_API.Data.ViewModels
{
    public class AuthorVM
    {
        public string FullName { get; set; }
    }


    public class AuthorwithBookVM
    {
        public string FullName { get; set; }
        public List<string> BookTitle { get; set; }   
    }

}
