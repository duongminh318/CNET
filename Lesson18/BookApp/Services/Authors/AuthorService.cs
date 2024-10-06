using BookApp.Repositories;
using BookApp.Services.Books;
using BookApp.UnitOfWork;
using Ex1GenericRepositoryUOW.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Services.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly IGenericRepository<Author, Guid> _authorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IGenericRepository<Author, Guid> authorRepository, IUnitOfWork unitOfWork)
        {
            _authorRepository = authorRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Create(CreateAuthorViewModel model)
        {
            var author = new Author()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
            };
            _authorRepository.Create(author);
            await _unitOfWork.SaveChange();
        }

        public async Task Delete(Guid id)
        {
            var author = await _authorRepository.FindById(id);
            if (author == null)
            {
                throw new Exception("Author not found");
            }

            _authorRepository.Delete(author);
            await _unitOfWork.SaveChange();
        }

        public async Task<List<AuthorViewModel>> GetAll()
        {
            var authors = _authorRepository.FindAll(null, s => s.Books).Select(
                s => new AuthorViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Books = s.Books.Select(x => new BookViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList()
                });
            var result = await authors.ToListAsync();
            return result;
        }

        public async Task<AuthorViewModel> GetById(Guid id)
        {
            var author = await _authorRepository.FindById(id, s => s.Books);
            if (author == null)
            {
                throw new Exception("Author not found");
            }

            var result = new AuthorViewModel()
            {
                Id = author.Id,
                Name = author.Name,
            };
            return result;
        }

        public async Task Update(UpdateAuthorViewModel model)
        {
            var author = await _authorRepository.FindById(model.Id);
            if (author == null)
            {
                throw new Exception("Author not found");
            }
            author.Name = model.Name;
            _authorRepository.Update(author);
            await _unitOfWork.SaveChange();
        }
    }
}
