using BackendGeneral.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularEducationBackend
{
    public class AngularEducationDatabaseLogger : ILogger
    {
        public AngularEducationDatabaseLogger(IDbContext dbContext)
        {
        }

        protected void LogEnitity<T>(string type, T entity)
        {
        }

        public void LogInsert<T>(T entity)
        {
            LogEnitity("Insert", entity);
        }

        public void LogUpdate<T>(T entity)
        {
            LogEnitity("Update", entity);
        }

        public void LogDelete<T>(T entity)
        {
            LogEnitity("Delete", entity);
        }

        public void Log(string loggingMessage, string stackTrace)
        {
            
        }
    }
}
