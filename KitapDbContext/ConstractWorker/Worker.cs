using Kitap.arama.AbstractWorker;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kitap.arama.ConstractWorker
{
    public class Worker : IWorker
    {
        private readonly KütüphaneContext _kütüphaneContext;
        public Worker(KütüphaneContext kütüphaneContext)
        {
            _kütüphaneContext = kütüphaneContext;
            
        }


        public async Task<Worder> CreateWorker(Worder worker)
        {
           await _kütüphaneContext.Worders.AddAsync(worker);
            await _kütüphaneContext.SaveChangesAsync();
            return worker;

        }

        public async void DeleteWorker(int id)
        {
           var delete = await _kütüphaneContext.Worders.FirstOrDefaultAsync(x=>x.WorkerID == id);
            if (delete != null)
            {
                _kütüphaneContext.Worders.Remove(delete);
                await _kütüphaneContext.SaveChangesAsync();
            }
        }

        public async Task<List<Worder>> GetAllWorker()
        {
          return await _kütüphaneContext.Worders.ToListAsync();
            
        }

        public async Task<Worder> GetWorkerById(int id)
        {
          var a =  await _kütüphaneContext.Worders.FirstOrDefaultAsync(x=>x.WorkerID == id);
            if(a != null)
            {
                return a;
            }
            else { return null ; }
        }

        public async Task<Worder> GetWorkerByName(string name)
        {
            var a= await _kütüphaneContext.Worders.FirstOrDefaultAsync(x=>x.WorkerName==name);
            if(a != null)
            {
                return a;
            }
            else { return null; }
        }

        public async Task<Worder> UpdateWorker(Worder worker)
        {
            var a = await _kütüphaneContext.Worders.FirstOrDefaultAsync(x=>x.WorkerID==worker.WorkerID);
            if(a != null)
            {
                a.WorkerName = worker.WorkerName;
                
                a.WorkerSurName = worker.WorkerSurName;

                a.WorkerDepertmant=worker.WorkerDepertmant;
                _kütüphaneContext.Update(worker);
                await _kütüphaneContext.SaveChangesAsync();
               
            }
            return a;
        }
    }
}
