using DAL.Linq;
using Interfaces.Repositories;

namespace DAL
{
    public sealed class DataContextManager : IDataContextManager
    {
        private static readonly Lazy<DataContextManager> instance = new Lazy<DataContextManager>(() => new DataContextManager());
        private readonly DataClassesDataContext _dataContext;

        public static DataContextManager Instance => instance.Value;

        private DataContextManager()
        {
            _dataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);
        }

        public object GetContext()
        {
            Monitor.Enter(_dataContext);
            try { return _dataContext; }
            finally { Monitor.Exit(_dataContext); }
        }

        public void Dispose()
        {
            Monitor.Enter(_dataContext);
            try { _dataContext.Dispose(); }
            finally { Monitor.Exit(_dataContext); }
        }
    }
}