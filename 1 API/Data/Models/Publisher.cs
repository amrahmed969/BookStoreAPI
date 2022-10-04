namespace _1_API.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Books> books { get; set; }
    }
}
