using WebDeveloperTools.Shared;

namespace WebDeveloperTools.Services.Interface
{
    public interface IConnectionStringService
    {
        public string GetConnectionString(ConnectionStringModel model);
    }
}
