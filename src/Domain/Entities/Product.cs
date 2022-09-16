using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Product : Entity
    {
        public Product(string name, string description, int availableQuantity,
            decimal unitPrice, decimal? discountAmount, Brand brand)
        {
            Name = name;
            Description = description;
            AvailableQuantity = availableQuantity;
            UnitPrice = unitPrice;
            DiscountAmount = discountAmount;
            Brand = brand;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int AvailableQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? DiscountAmount { get; set; }
        public virtual Brand Brand { get; set; }


    }
}
