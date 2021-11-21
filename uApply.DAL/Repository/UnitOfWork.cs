using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;

namespace uApply.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext db;

        public UnitOfWork(ApplicationDbContext db)
        {
            this.db = db;
            District = new DistrictRepository(db);
        }

        public IDistrictRepository District { get; private set; }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
