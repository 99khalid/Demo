

namespace Demo.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
