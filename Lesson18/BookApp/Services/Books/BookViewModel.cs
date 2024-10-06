namespace BookApp.Services.Books
{
    public class UpdateBookViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid AuthorId { get; set; }
    }
}
