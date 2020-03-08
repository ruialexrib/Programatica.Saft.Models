namespace Programatica.Saft.Models
{
    public interface IBillingAddress
    {
        string AddressDetail { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
        string Region { get; set; }
    }
}