using Kitap.arama.MüşteriAbstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap.arama.MüşteriConstract
{
    public class Müşteri : IMüşteri
    {
        private readonly KütüphaneContext _kütüphaneContext;
        public Müşteri(KütüphaneContext kütüphaneContext)
        {
            _kütüphaneContext = kütüphaneContext;

        }
        public async Task<arama.Müşteri> CreateMüşteri(arama.Müşteri müşteri)
        {
            await _kütüphaneContext.Müşteris.AddAsync(müşteri);
            await _kütüphaneContext.SaveChangesAsync();
            return müşteri;

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

        public async Task<List<arama.Müşteri>> GetAllMüşteri()
        {
          var a = await _kütüphaneContext.Müşteris.ToListAsync();
            return a;
        }

        public async Task<arama.Müşteri> GetByMüşteriID(int id)
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

        public async Task<arama.Müşteri> GetByMüşteriName(arama.Müşteri müşteri)
        {
            var a = await _kütüphaneContext.Müşteris.FirstOrDefaultAsync(x => x.MüşteriAd==müşteri.MüşteriAd  );
            if (a != null)
            {
                return a;
            }
            else
            {
                return null;
            }
        }

        public async Task<arama.Müşteri> UpdateMüşteri(arama.Müşteri müşteri)
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
