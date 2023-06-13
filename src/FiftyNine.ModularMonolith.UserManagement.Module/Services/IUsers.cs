namespace Module.UserManagement.Services
{
    public interface IUsers
    {
        Task<Integration.UserManagement.Model.UserDetails?> WithIdd(int id);
    }
}
