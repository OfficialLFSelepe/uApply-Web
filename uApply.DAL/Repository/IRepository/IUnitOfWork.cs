using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.DAL.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IDistrictRepository District { get; }
        IParentRepository Parent { get; }
        ITitleRepository Title { get; }
        IGenderRepository Gender { get; }
        IRaceRepository Race { get; }
        INationalityRepository Nationality { get; }
        ILanguageRepository Language { get; }
        ILearnerRepository Learner { get; }

        
        void Save();
    }
}
