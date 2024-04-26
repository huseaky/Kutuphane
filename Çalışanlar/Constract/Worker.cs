using Çalışanlar.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Çalışanlar.Constract
{
    public class Worker : IWorker
    {
        private readonly KütüphaneContext _kütüphaneContext;
        public Worder(KütüphaneContext kütüphaneContext)
        {
            _kütüphaneContext = kütüphaneContext;
        }
        public Task<Worder> CreateWorker(Worder worker)
        {
            throw new NotImplementedException();
        }

        public void DeleteWorker(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Worder>> GetAllWorker()
        {
            throw new NotImplementedException();
        }

        public Task<Worder> GetWorkerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Worder> GetWorkerByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Worder> UpdateWorker(Worder worker)
        {
            throw new NotImplementedException();
        }
    }
}
