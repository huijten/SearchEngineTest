using System.ComponentModel.Design;

namespace SearchEngineTest.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public Employee Creator { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
