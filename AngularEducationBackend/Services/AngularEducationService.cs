using AngularEducationBackend.Providers;
using AngularEducationBackend.Repositories;
using BackendGeneral;
using BackendGeneral.Interfaces;

namespace AngularEducationBackend.Services
{
    public class AngularEducationService<T> : Service<T, AngularEducationRepository<T>, AngularEducationServiceProvider>
        where T : class, IIdentifiable
    {
        public AngularEducationService(AngularEducationRepository<T> repository, AngularEducationServiceProvider serviceProvider, IDbContext dbContext)
            : base(repository, serviceProvider, dbContext, new AngularEducationDatabaseLogger(dbContext), new AngularEducationMemoryCache())
        {
        }
    }
}
