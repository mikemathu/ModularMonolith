namespace Integration.UserManagement;

public class User
{
    public static User Create(int id, string firstName, string lastName)
        => new User
        {
            Id = id,
            FirstName = firstName,
            LastName = lastName
        };

    public int Id { get; init; }
   /* public string FirstName { get; init; } = string.Empty;*/
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}
