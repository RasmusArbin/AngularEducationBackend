using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendGeneral;
using BackendGeneral.Interfaces;

namespace AngularEducationBackend.Repositories
{
    public class AngularEducationRepository<T> : Repository<T>
        where T : class, IIdentifiable
    {
        public AngularEducationRepository(IDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
