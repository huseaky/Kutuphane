using Kitap.arama.SubeAbstarct;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap.arama.SubeConstract
{
    public class Sube : ISubeler
    {
        private readonly KütüphaneContext _kütüphaneContext;
        public Sube(KütüphaneContext kütüphaneContext)
        {
            _kütüphaneContext = kütüphaneContext;
        }
        public async Task<arama.Sube> CreateSube(arama.Sube sube)
        {
            await _kütüphaneContext.Subes.AddAsync(sube);
            await _kütüphaneContext.SaveChangesAsync();
            return sube;
        }

        public async void DeleteSube(int id)
        {
            var a = await _kütüphaneContext.Subes.FirstOrDefaultAsync(x=>x.ŞubeID == id);
            if (a != null)
            {
                _kütüphaneContext.Remove(a);
                await _kütüphaneContext.SaveChangesAsync();
            }
        }

        public async Task<List<arama.Sube>> GetAllSube()
        {
          return await _kütüphaneContext.Subes.ToListAsync();
            
        }

        public Task<arama.Sube> GetBySubeID(int id)
        {
          var a =  _kütüphaneContext.Subes.FirstOrDefaultAsync(x=>x.ŞubeID==id);
            if (a != null)
            {
                return a;
            }
            else
            {
                return null;
            }
        }


        public async Task<arama.Sube> UpdateSube(arama.Sube sube)
        {
            var a = await _kütüphaneContext.Subes.FirstOrDefaultAsync(x => x.ŞubeUlke==sube.ŞubeUlke ); 
            if (a != null)
            {
                a.ŞubeUlke = sube.ŞubeUlke;
                a.ŞubeSokak = sube.ŞubeSokak;
                a.ŞubeMahalle = sube.ŞubeMahalle;
                await _kütüphaneContext.SaveChangesAsync();
            }
            return a;
        }
    }
}
