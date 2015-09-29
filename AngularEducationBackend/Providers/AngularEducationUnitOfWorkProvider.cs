using BackendGeneral.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularEducationBackend.Providers
{
    public class AngularEducationUnitOfWorkProvider : UnitOfWorkProvider<AngularEducationUnitOfWork, AngularEducationDbContext, AngularEducationServiceProvider>
    {
    }
}
