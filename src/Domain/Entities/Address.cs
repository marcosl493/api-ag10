using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Address : Entity
    {
        public Address(bool isActive, bool isPrincipal, Customer customer, AddressDescription description)
        {

            IsActive = isActive;
            IsPrincipal = isPrincipal;
            Customer = customer;
            Description = description;
        }

        public AddressDescription Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsPrincipal { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
