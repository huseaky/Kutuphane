using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışanlar.Abstract
{
    public interface IWorker
    {
        Task<List<Worder>> GetAllWorker();

        Task<Worder> CreateWorker(Worder worker);

        Task<Worder> UpdateWorker(Worder worker);
        Task<Worder> GetWorkerById(int id);
        Task<Worder> GetWorkerByName(string name);
        void DeleteWorker(int id);
    }
}
