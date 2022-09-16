using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Customer : User
    {
        public Customer(string name, string email, string hash, string cpf, string phoneNumber) : base(name, email, hash)
        {
            Cpf = cpf;
            PhoneNumber = phoneNumber;
        }

        public string Cpf { get; set; }
        public string PhoneNumber { get; set; }
        public bool ItsBlocked { get; set; }
    }
}
