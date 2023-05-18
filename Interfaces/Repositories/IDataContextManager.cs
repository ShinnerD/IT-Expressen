namespace Interfaces.Repositories
{
    public interface IDataContextManager : IDisposable
    {
        static IDataContextManager? Instance { get; }

        object GetContext();
    }
}