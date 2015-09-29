using BackendGeneral.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularEducationBackend
{
    public class AngularEducationMemoryCache : ICache
    {
        public AngularEducationMemoryCache()
        {
            //TODO: Implement
        }

        public void Set(string expression, object item)
        {
            //_cache.Set(expression, item, _policy);
        }

        public T Get<T>(string expression)
        {
            //TODO: Implement
            return default(T);
        }

        public void Remove(string expression)
        {
            //TODO: Implement
        }
    }
}
