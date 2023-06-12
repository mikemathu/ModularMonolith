namespace Modules.UserManagement.Extensions;

public static class UserExtensions
{
    public static Integration.UserManagement.Model.UserDetails ToUser(this Integration.UserManagement.Model.UserDetails user)
        => Integration.UserManagement.DTO.User.Create(user.Id, user.FirstName, user.LastName);
}