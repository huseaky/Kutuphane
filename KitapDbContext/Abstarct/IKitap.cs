using Kitap.arama.Constract;
using Kütüphane.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kitap.arama.Abstarct
{
    public interface IKitap
    {
        Task <List<Book>> GetAllKitap();
        Task<Book> CreateKitap(Book book);
        Task<Book> UpdateKitap(Book book);

        Task<Book> GetKitapById(int id);

        Task<Book> GetKitapByName(string name);

        void DeleteKitap(int id);

    }
}
