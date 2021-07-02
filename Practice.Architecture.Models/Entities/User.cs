using System.Collections.Generic;

namespace Practice.Architecture.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public System.DateTime BirthDate { get; set; }
        public ICollection<Employee> Employes { get; set; }
    }
}
