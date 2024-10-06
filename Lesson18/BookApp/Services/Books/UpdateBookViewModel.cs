namespace BookApp.Services.Books
{
    public class BookViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
