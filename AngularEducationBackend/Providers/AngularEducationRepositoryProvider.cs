using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendGeneral.Providers;
using BackendGeneral.Interfaces;
using BackendGeneral;
using AngularEducationBackend.Repositories;

namespace AngularEducationBackend.Providers
{
    public class AngularEducationRepositoryProvider : RepositoryProvider
    {
        public AngularEducationRepositoryProvider(IDbContext dbContext) : base(dbContext)
        {
        }

        private Repository<tblGame> _gameRepository;
        public Repository<tblGame> GameRepository
        {
            get
            {
                return _gameRepository ?? (_gameRepository = new AngularEducationRepository<tblGame>(DbContext));
            }
        }
    }
}
