using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Order : Entity
    {
        public Order(string preferenceId, decimal price, bool isDelivered,
            bool isPaid, DateTime requestDate, Customer customer,
            Address address, ICollection<Sale> sales)
        {
            PreferenceId = preferenceId;
            Price = price;
            IsDelivered = isDelivered;
            IsPaid = isPaid;
            RequestDate = requestDate;
            Customer = customer;
            Address = address;
            Sales = sales;
        }

        public string PreferenceId { get; set; }
        public decimal Price { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsPaid { get; set; }
        public DateTime RequestDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
