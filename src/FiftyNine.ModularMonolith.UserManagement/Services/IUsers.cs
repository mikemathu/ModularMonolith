using Integration.UserManagement.Model;
using System.Net;

namespace Integration.UserManagement.Services;

public interface IUsers
{
    Task<UserDetails?> WithIdd(int id);
    Task<IEnumerable<UserDetails>> WithId(int id);
}
