namespace Api.Models
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Fname  { get; set; }
        public string Lname  { get; set; }
    }

    public class UserVMList
    {
        public IEnumerable<UserVM> UsersList { get; set; }
    }
}
