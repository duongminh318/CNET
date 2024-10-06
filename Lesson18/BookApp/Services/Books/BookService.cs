using BookApp.Repositories;
using BookApp.UnitOfWork;
using Ex1RepositoryUOW.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Services.Books
{
    public class BookService : IBookService
    {
        private readonly IGenericRepository<Book, Guid> _bookRepository;
        private readonly IUnitOfWork _unitOfWork;
        public BookService(IGenericRepository<Book, Guid> bookRepository, IUnitOfWork unitOfWork)
        {
            _bookRepository = bookRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Create(CreateBookViewModel model)
        {
            var book = new Book()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                AuthorId = model.AuthorId
            };
            _bookRepository.Create(book);
            await _unitOfWork.SaveChange();
        }

        public async Task Delete(Guid id)
        {
            var book = await _bookRepository.FindById(id);
            if (book == null)
            {
                throw new Exception("Book not found");
            }

            _bookRepository.Delete(book);
            await _unitOfWork.SaveChange();
        }

        public async Task<List<BookViewModel>> GetAll()
        {
            var books = _bookRepository.FindAll(null, s => s.Author).Select(
                s => new BookViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    AuthorName = s.Author.Name
                });
            var result = await books.ToListAsync();
            return result;
        }

        public async Task<BookViewModel> GetById(Guid id)
        {
            var book = await _bookRepository.FindById(id, s => s.Author);
            if (book == null)
            {
                throw new Exception("Book not found");
            }

            var result = new BookViewModel()
            {
                Id = book.Id,
                Name = book.Name,
                AuthorName = book.Author.Name,
                AuthorId = book.AuthorId
            };
            return result;
        }

        public async Task Update(UpdateBookViewModel model)
        {
            var book = await _bookRepository.FindById(model.Id);
            if (book == null)
            {
                throw new Exception("Book not found");
            }
            book.Name = model.Name;
            book.AuthorId = model.AuthorId;
            _bookRepository.Update(book);
            await _unitOfWork.SaveChange();
        }
    }
}
