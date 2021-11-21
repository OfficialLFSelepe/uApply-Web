using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;

namespace uApply.DAL.Repository.IRepository
{
    public interface IDistrictRepository : IRepository<District>
    {
        void Update(District district);
    }
}
