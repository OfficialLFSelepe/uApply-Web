using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.DAL.Repository
{
    public class LearnerRepository : Repository<Learner>, ILearnerRepository
    {
        private readonly ApplicationDbContext db;

        public LearnerRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Learner learner)
        {
            throw new NotImplementedException();
        }
    }
}
