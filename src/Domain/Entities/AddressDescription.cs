namespace Domain.Entities
{
    public class AddressDescription
    {
        public AddressDescription(string neighborhood, string city, string publicArea, int houseNumber, string? complement, string zipCode)
        {
            Neighborhood = neighborhood;
            City = city;
            PublicArea = publicArea;
            HouseNumber = houseNumber;
            Complement = complement;
            ZipCode = zipCode;
        }

        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string PublicArea { get; set; }
        public int HouseNumber { get; set; }
        public string? Complement { get; set; }
        public string ZipCode { get; set; }
    }
}
