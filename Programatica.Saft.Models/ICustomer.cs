using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface ICustomer
    {
        string AccountID { get; set; }
        BillingAddress BillingAddress { get; set; }
        string CompanyName { get; set; }
        string Contact { get; set; }
        string CustomerID { get; set; }
        string CustomerTaxID { get; set; }
        string Email { get; set; }
        string Fax { get; set; }
        string SelfBillingIndicator { get; set; }
        List<ShipToAddress> ShipToAddress { get; set; }
        string Telephone { get; set; }
        string Website { get; set; }
    }
}