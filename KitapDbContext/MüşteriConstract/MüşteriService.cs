using Kitap.arama.Models.DTOs;
using Kitap.arama.MüşteriAbstract;
using Kütüphane.Entitiy;
using Microsoft.EntityFrameworkCore;
namespace Kitap.arama.MüşteriConstract
{
    public class MüşteriService : IMüşteri
    {
        private readonly KütüphaneContext _kütüphaneContext;
        public MüşteriService(KütüphaneContext kütüphaneContext)
        {
            _kütüphaneContext = kütüphaneContext;

        }
        public async Task<Müşteri> CreateMüşteri(MüşteriDTO müşteri)
        {
            Müşteri _müşteri = new()
            {
                MüşteriAd=müşteri.MüşteriAd,
                MüşteriSoyAd=müşteri.MüşteriSoyAd,
                KiralananKitapSayısı=0,
                OkunanKitapSayısı =0
                
            };
            foreach(int id in müşteri.BookIds)
            {
                Book? foundbook=await _kütüphaneContext.Books.FirstOrDefaultAsync(x=>x.ID==id);
                _müşteri.Books.Add(foundbook);
                
            }
            await _kütüphaneContext.Müşteris.AddAsync(_müşteri);
            await _kütüphaneContext.SaveChangesAsync();
            return _müşteri;
      

        }

        public async void DeleteMüşteri(int id)
        {
            var a= await _kütüphaneContext.Müşteris.FirstOrDefaultAsync(x=>x.MüşteriID==id);
            if (a!=null)
            {
                _kütüphaneContext.Remove(id);
                await _kütüphaneContext.SaveChangesAsync() ;
            }
        }

        public async Task<List<Müşteri>> GetAllMüşteri()
        {
          var a = await _kütüphaneContext.Müşteris.ToListAsync();
            return a;
        }

        public async Task<Müşteri> GetByMüşteriID(int id)
        {
            var a = await _kütüphaneContext.Müşteris.FirstOrDefaultAsync(x=>x.MüşteriID == id);
            if (a != null)
            {
                return a;
            }
            else
            {
                return null;
            }
        }

        public async Task<Müşteri> GetByMüşteriName(string name)
        {
            var a = await _kütüphaneContext.Müşteris.FirstOrDefaultAsync(x => x.MüşteriAd==name);
            if (a != null)
            {
                return a;
            }
            else
            {
                return null;
            }
        }

      

        public async Task<Müşteri> UpdateMüşteri(Müşteri müşteri)
        {
            var a = await    _kütüphaneContext.Müşteris.FirstOrDefaultAsync(x => x.MüşteriAd == müşteri.MüşteriAd);
            if (a != null)
            {
                a.MüşteriAd = müşteri.MüşteriAd;
                a.MüşteriSoyAd = müşteri.MüşteriSoyAd;
                await _kütüphaneContext.SaveChangesAsync();

            }
            return a;
        }
    }
}
