using BookApp.Services.Books;

namespace BookApp.Services.Authors
{
    public class AuthorViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<BookViewModel> Books { get; set; }
    }
}
