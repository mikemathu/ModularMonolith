namespace Module.UserManagement.Services
{
    public interface IUsers
    {
        Task<Integration.UserManagement.UserDetails?> WithId(int id);
    }
}
