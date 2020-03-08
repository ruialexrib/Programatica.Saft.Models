using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IPayment
    {
        string ATCUD { get; set; }
        string CustomerID { get; set; }
        string Description { get; set; }
        DocumentStatus DocumentStatus { get; set; }
        DocumentTotals DocumentTotals { get; set; }
        List<Line> Line { get; set; }
        string PaymentAmount { get; set; }
        string PaymentDate { get; set; }
        string PaymentMechanism { get; set; }
        List<PaymentMethod> PaymentMethod { get; set; }
        string PaymentRefNo { get; set; }
        string PaymentType { get; set; }
        string Period { get; set; }
        string SourceID { get; set; }
        string SystemEntryDate { get; set; }
        string SystemID { get; set; }
        string TransactionDate { get; set; }
        string TransactionID { get; set; }
        WithholdingTax WithholdingTax { get; set; }
    }
}