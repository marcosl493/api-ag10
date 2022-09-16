namespace Domain.Entities.Abstract
{
    public abstract class User : Entity
    {
        protected User(string name, string email, string hash)
        {
            Name = name;
            Email = email;
            Hash = hash;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
    }
}
