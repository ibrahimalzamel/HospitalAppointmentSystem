using Core.Domain;

namespace Domain.Entities
{
    public class Gender : Entity<short>
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
