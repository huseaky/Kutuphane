using Kitap.arama.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap.arama.MüşteriAbstract
{
    public interface IMüşteri
    {
        Task<List<Müşteri>> GetAllMüşteri();
        Task<Müşteri> CreateMüşteri(MüşteriDTO müşteri);

        void DeleteMüşteri(int id);

        Task<Müşteri> GetByMüşteriID(int id);

        Task<Müşteri> GetByMüşteriName(string name);


        Task<Müşteri> UpdateMüşteri(Müşteri müşteri);
    }
}
