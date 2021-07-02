
namespace Practice.Architecture.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Rol { get; set; }
        public string Salary { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
    }
}
