using DAL.Linq;
using Interfaces.Repositories;

namespace DAL
{
    /// <summary>
    /// Singleton class that encapsulates the creation and management of the data context. 
    /// It ensures that only one instance of the DataContextManager is created. Access with the Instance property.
    /// The class uses Monitor to ensure thread safety when accessing the data context. /Dennis Kempf
    /// </summary>
    public class DataContextManager : IDataContextManager
    {
        private static readonly Lazy<DataContextManager> instance = new Lazy<DataContextManager>(() => new DataContextManager(), LazyThreadSafetyMode.ExecutionAndPublication);
        private readonly DataClassesDataContext _dataContext;

        public static DataContextManager Instance => instance.Value;

        private DataContextManager()
        {
            _dataContext = new DataClassesDataContext(DbConnectionString.ConnectionString);
        }

        public object GetContext()
        {
            try
            {
                Monitor.Enter(_dataContext);
                return _dataContext;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to retrieve the data context.", ex);
            }
            finally
            {
                Monitor.Exit(_dataContext);
            }
        }

        void IDisposable.Dispose()
        {
            try
            {
                Monitor.Enter(_dataContext);
                _dataContext.Dispose();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to dispose of the data context.", ex);
            }
            finally
            {
                Monitor.Exit(_dataContext);
            }
        }
    }
}