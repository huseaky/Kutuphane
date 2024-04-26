using Kütüphane.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap.arama.SubeAbstarct
{
    public interface ISubeler
    {
        Task<List<Sube>> GetAllSube();
        Task<Sube> CreateSube(Sube sube);

        void DeleteSube(int id);

        Task<Sube> GetBySubeID(int id);

        Task<Sube> UpdateSube(Sube sube);

    }
}
