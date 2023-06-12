using Integration.UserManagement.Model;

namespace Integration.UserManagement.DTO;

public class User
{
    public static UserDetails Create(int id, string firstName, string lastName)
    {
        var user = new UserDetails
        {
            Id = id,
            FirstName = firstName,
            LastName = lastName
        };
        return user;
    }


}
