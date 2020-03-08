namespace Programatica.Saft.Models
{
    public interface IShipToAddress
    {
        string AddressDetail { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
    }
}