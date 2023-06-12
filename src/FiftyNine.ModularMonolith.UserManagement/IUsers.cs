namespace Integration.UserManagement;

public interface IUsers
{
    Task<User?> WithId(int id);
}
