using Integration.UserManagement.Model;

namespace Integration.UserManagement.Services;

public interface IUsers
{
    Task<UserDetails?> WithId(int id);
}
