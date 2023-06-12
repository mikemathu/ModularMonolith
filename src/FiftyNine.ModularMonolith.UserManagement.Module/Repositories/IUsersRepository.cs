﻿namespace Module.UserManagement.Repositories
{

    public class IUsersRepository : Module.UserManagement.Services.IUsers, Integration.UserManagement.IUsers
    {
        public Task<Integration.UserManagement.UserDetails?> WithId(int id)
        {
            if (id != 1)
            {
                return Task.FromResult<Integration.UserManagement.UserDetails?>(null);
            }

            return Task.FromResult<Integration.UserManagement.UserDetails?>(Integration.UserManagement.User.Create(id, "Michael", "Mathu"));
        }

    /*    Task<Integration.UserManagement.User?> Integration.UserManagement.IUsers.WithId(int id)
            => WithId(id).ContinueWith(x => x.Result?.ToUser());*/
    }
}
