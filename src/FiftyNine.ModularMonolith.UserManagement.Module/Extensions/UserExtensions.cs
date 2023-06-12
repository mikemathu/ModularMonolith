namespace Modules.UserManagement.Extensions;

public static class UserExtensions
{
    public static Integration.UserManagement.User ToUser(this Integration.UserManagement.User user)
        => Integration.UserManagement.User.Create(user.Id, user.FirstName, user.LastName);
}
