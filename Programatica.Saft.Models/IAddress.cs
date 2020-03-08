namespace Programatica.Saft.Models
{
    public interface IAddress
    {
        string AddressDetail { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
        string Region { get; set; }
    }
}