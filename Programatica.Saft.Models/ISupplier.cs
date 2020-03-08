namespace Programatica.Saft.Models
{
    public interface ISupplier
    {
        string AccountID { get; set; }
        BillingAddress BillingAddress { get; set; }
        string CompanyName { get; set; }
        string Contact { get; set; }
        string Email { get; set; }
        string Fax { get; set; }
        string SelfBillingIndicator { get; set; }
        ShipFromAddress ShipFromAddress { get; set; }
        string SupplierID { get; set; }
        string SupplierTaxID { get; set; }
        string Telephone { get; set; }
    }
}