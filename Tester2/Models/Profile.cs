namespace Tester2.Models
{
    public class Profile
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? UserEmail { get; set; }
        public Profile()
        {

        }
        public Profile(string name)
        {
            Name = name;
        }
    }
}
