
namespace Demo.Domain
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
