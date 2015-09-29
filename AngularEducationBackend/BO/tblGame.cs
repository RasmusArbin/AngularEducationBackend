using BackendGeneral.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularEducationBackend
{
    public partial class tblGame : IIdentifiable
    {
        public int Id
        {
            get
            {
                return GameId;
            }
        }
    }
}
