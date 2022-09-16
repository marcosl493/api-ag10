using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Manager : User
    {
        public Manager(string name, string email, string hash) : base(name, email, hash)
        {
        }
    }
}
