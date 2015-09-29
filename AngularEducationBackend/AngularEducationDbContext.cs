using BackendGeneral.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AngularEducationBackend
{
    public class AngularEducationDbContext : AngularEducationGamesEntities1, IDbContext
    {
        const string QUERY_NAME_PREFIX = "@";
        const string TBL_PREFIX = "";

        public ITable<TEntity> DbSet<TEntity>()
            where TEntity : class
        {
            return new AngularEducationDbSet<TEntity>(this, Set<TEntity>());
        }

        public new void Dispose()
        {
            SaveChanges();
            base.Dispose();
        }

        public string GetQueryableAsString<T>(IQueryable<T> queryable)
        {
            var objectQuery = (ObjectQuery<T>)GetPropertyValue(GetPropertyValue(queryable, "InternalQuery"), "ObjectQuery");

            string queryString = objectQuery.ToTraceString();
            foreach (var p in objectQuery.Parameters)
            {
                queryString = queryString.Replace(QUERY_NAME_PREFIX + p.Name, (p.Value ?? "").ToString());
            }
            return queryString;
        }

        private static object GetPropertyValue(object o, string Name)
        {
            return o.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Where(x => x.Name == Name).First().GetValue(o, null);
        }

        public List<string> GetDependencies<T>(IQueryable<T> queryable)
        {
            string expression = GetQueryableAsString(queryable);

            //Get all classes that can be idetified by Id
            var types =
                        from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetInterfaces().Contains(typeof(IIdentifiable))
                        select t;

            return
                types
                    .Where(type => expression.Contains(string.Format("[{0}{1}]", TBL_PREFIX, type.Name)))
                    .Select(type => type.Name)
                    .ToList();
        }
    }
}
