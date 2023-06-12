namespace Module.UserManagement.Repositories
{

    public class IUsersRepository : Module.UserManagement.Services.IUsers, Integration.UserManagement.Services.IUsers
    {
        public Task<Integration.UserManagement.Model.UserDetails?> WithId(int id)
        {
            if (id != 1)
            {
                return Task.FromResult<Integration.UserManagement.Model.UserDetails?>(null);
            }

            return Task.FromResult<Integration.UserManagement.Model.UserDetails?>(Integration.UserManagement.DTO.User.Create(id, "Michael", "Mathu"));
        }

    /*    Task<Integration.UserManagement.User?> Integration.UserManagement.IUsers.WithId(int id)
            => WithId(id).ContinueWith(x => x.Result?.ToUser());*/
    }
}
