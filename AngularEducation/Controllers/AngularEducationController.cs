using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using AngularEducationBackend.Providers;

namespace AngularEducation.Controllers
{
    public class AngularEducationController : ApiController
    {
        private AngularEducationUnitOfWorkProvider _angularEducationUnitOfWorkProvider;
        public AngularEducationUnitOfWorkProvider AngularEducationUnitOfWorkProvider
        {
            get
            {
                return _angularEducationUnitOfWorkProvider ??
                       (_angularEducationUnitOfWorkProvider = new AngularEducationUnitOfWorkProvider());
            }
        }
    }
}
