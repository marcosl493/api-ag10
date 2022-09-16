using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }

        public Brand(string name)
        {
            Name = name;
        }
    }
}
