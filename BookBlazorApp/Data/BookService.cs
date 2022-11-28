using Microsoft.EntityFrameworkCore;

namespace BookBlazorApp.Data
{
    public class BookService
    {
        private readonly AppDbContext _appDbContext;

        public BookService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _appDbContext.Books.ToListAsync();
        }

        public async Task<bool> InsertBookAsync(Book book)
        {
            await _appDbContext.Books.AddAsync(book);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Book?> GetBookAsync(int Id)
        {
            return await _appDbContext.Books.FirstOrDefaultAsync(b => b.Id.Equals(Id));
        }

        public async Task<bool> UpdateBookAsync(Book book)
        {
            _appDbContext.Books.Update(book);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteBookAsync(Book book)
        {
            _appDbContext.Books.Remove(book);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}
