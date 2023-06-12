namespace Module.UserManagement.Services
{
    public interface IUsers
    {
        Task<Integration.UserManagement.User?> WithId(int id);
    }
}
