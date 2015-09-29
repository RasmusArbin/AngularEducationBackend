using AngularEducationBackend.Providers;
using BackendGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularEducationBackend
{
    public class AngularEducationUnitOfWork : UnitOfWork<AngularEducationDbContext, AngularEducationServiceProvider>
    {
        protected AngularEducationServiceProvider _angularEducationServiceProvider;
        protected override AngularEducationServiceProvider ServiceProvider
        {
            get
            {
                return _angularEducationServiceProvider ??
                       (_angularEducationServiceProvider = new AngularEducationServiceProvider(DbContext));
            }
        }
    }
}
