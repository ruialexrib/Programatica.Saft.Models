namespace Programatica.Saft.Models
{
    public interface IShipFromAddress
    {
        string AddressDetail { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
    }
}