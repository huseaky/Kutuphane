using Kitap.arama.Abstarct;
using Kütüphane.Entitiy;
using Microsoft.EntityFrameworkCore;

namespace Kitap.arama.Constract
{
    public class KitapController : IKitap
    {
        private readonly KütüphaneContext _kütüphaneContext;
        public KitapController(KütüphaneContext kütüphaneContext)
        {
            _kütüphaneContext = kütüphaneContext;
        }
        public async Task<Book> CreateKitap(Book book)
        {
            await _kütüphaneContext.Books.AddAsync(book);
            await _kütüphaneContext.SaveChangesAsync();
            return book;
        }

        public async void DeleteKitap(int id)
        {
            var bookDelete = await _kütüphaneContext.Books.FirstOrDefaultAsync(k => k.ID == id);
            if (bookDelete != null)
            {
                _kütüphaneContext.Remove(bookDelete);
                await _kütüphaneContext.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> GetAllKitap()
        {

            return await _kütüphaneContext.Books.ToListAsync();
        }

        public async Task<Book> GetKitapById(int id)
        {
            var book = await _kütüphaneContext.Books.FirstOrDefaultAsync(b => b.ID == id);
            if (book != null)
            {
                
                return book;
            }
            else { return null; }

        }

        public async Task<Book> GetKitapByName(string name)
        {
            var book = await _kütüphaneContext.Books.FirstOrDefaultAsync(b => b.KitapAdı == name);
            if (book != null)
            {
                return book;
            }
            else { return null; }
        }

        public async Task<Book> UpdateKitap(Book book)
        {
            var _book = await _kütüphaneContext.Books.FirstOrDefaultAsync(x => x.ID == book.ID);
            if (_book != null)
            {
                _book.KitapAdı = book.KitapAdı;
                _kütüphaneContext.Update(_book);
                await _kütüphaneContext.SaveChangesAsync();

            }
            return _book;

        }
    }
}
