using WebDeveloperTools.Services.Interface;
using WebDeveloperTools.Shared;

namespace WebDeveloperTools.Services
{
    public class ConnectionStringService : IConnectionStringService
    {
        public string GetConnectionString(ConnectionStringModel model)
        {
            //Exemplo : "Server=localhost;Database=Treino;User Id=sa;Password=M@sterk3y;TrustServerCertificate=True"
            var connection = $"Server={model.Server};Database={model.Database};User Id={model.Username};Password={model.Password};";
            if(model.IsSecureConnection)
            {
                connection += "TrustServerCertificate=True";
            }
            return connection;
        }
    }
}
