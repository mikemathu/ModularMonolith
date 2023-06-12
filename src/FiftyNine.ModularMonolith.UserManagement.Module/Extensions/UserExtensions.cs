namespace Modules.UserManagement.Extensions;

public static class UserExtensions
{
    public static Integration.UserManagement.UserDetails ToUser(this Integration.UserManagement.UserDetails user)
        => Integration.UserManagement.User.Create(user.Id, user.FirstName, user.LastName);
}
