using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Sale : Entity
    {
        public Sale(Product product, int productQuantity)
        {
            Product = product;
            ProductQuantity = productQuantity;
        }

        public virtual Product Product { get; set; }
        public int ProductQuantity { get; set; }

    }
}
