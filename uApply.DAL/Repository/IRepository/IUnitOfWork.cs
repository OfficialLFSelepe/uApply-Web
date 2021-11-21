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
        void Save();
    }
}
