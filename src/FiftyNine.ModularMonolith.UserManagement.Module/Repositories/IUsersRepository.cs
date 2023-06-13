using Npgsql;
using System.Data.Common;
using System.Net;

namespace Module.UserManagement.Repositories
{

    public class IUsersRepository : Module.UserManagement.Services.IUsers, Integration.UserManagement.Services.IUsers
    {
        private const string _usersTable = "users";
        private IConfiguration _config;
        private NpgsqlConnection? _connection;
        public IUsersRepository(IConfiguration config)
        {
            _config =  config;
        }
        private void OpenConnection()
        {
/*            string connectionString = _config.GetConnectionString("DefaultConnection");*/
            string connectionString = String.Format("Host=localhost; Database=ModularMonolith; Username=postgres; Password=*mikemathu");

            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }
        public Task<Integration.UserManagement.Model.UserDetails?> WithIdd(int id)
        {
            if (id != 1)
            {
                return Task.FromResult<Integration.UserManagement.Model.UserDetails?>(null);
            }

            return Task.FromResult<Integration.UserManagement.Model.UserDetails?>(Integration.UserManagement.DTO.User.Create(id, "Michael", "Mathu"));
        }

        /*    Task<Integration.UserManagement.User?> Integration.UserManagement.IUsers.WithId(int id)
                => WithId(id).ContinueWith(x => x.Result?.ToUser());*/

      /*  public async Task<IEnumerable<ServicePointVM>> GetServices()*/
        public async Task<IEnumerable<Integration.UserManagement.Model.UserDetails?>> WithId(int id)
        {
            OpenConnection();
          /*  _connection.Open();*/
         
            List<Integration.UserManagement.Model.UserDetails> services = new List<Integration.UserManagement.Model.UserDetails>();

         /*   string commandText = $"SELECT id, FirstName, LastName FROM {_usersTable}";*/
            string commandText = $"SELECT * FROM {_usersTable}";
            using (NpgsqlCommand command = new NpgsqlCommand(commandText, _connection))
            {
                using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        services.Add(new Integration.UserManagement.Model.UserDetails
                        {
                            Id = (int)reader["id"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"]
                        });
                    }
                    reader.Close();
                }
                _connection.Close();
            }
            if (services.Count() == 0)
                return null;
            return services;
        }

    }
}
