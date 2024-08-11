using Core.Domain;

namespace Domain.Entities
{
    public class BloodType : Entity<short>
    {
        public string Name { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
