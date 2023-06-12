namespace Integration.UserManagement;

public interface IUsers
{
    Task<UserDetails?> WithId(int id);
}
