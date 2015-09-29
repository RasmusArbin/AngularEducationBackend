using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendGeneral.Providers;
using BackendGeneral.Interfaces;
using AngularEducationBackend.Services;
using AngularEducationBackend.Repositories;

namespace AngularEducationBackend.Providers
{
    public class AngularEducationServiceProvider : ServiceProvider
    {
        public AngularEducationServiceProvider(IDbContext dbContext)
            : base(dbContext)
        {
            
        }

        private AngularEducationRepositoryProvider _repositoryProvider;

        protected AngularEducationRepositoryProvider RepositoryProvider
        {
            get
            {
                return _repositoryProvider ?? (_repositoryProvider = new AngularEducationRepositoryProvider(DbContext));
            }
        }

        private AngularEducationService<tblGame> _gameService;
        public AngularEducationService<tblGame> GamePlayerService
        {
            get
            {
                return _gameService ?? (_gameService = new AngularEducationService<tblGame>(new AngularEducationRepository<tblGame>(DbContext), this, DbContext));
            }
        }
    }
}
