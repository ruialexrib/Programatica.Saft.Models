using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IInvoice
    {
        string ATCUD { get; set; }
        string CustomerID { get; set; }
        DocumentStatus DocumentStatus { get; set; }
        DocumentTotals DocumentTotals { get; set; }
        string EACCode { get; set; }
        string Hash { get; set; }
        string HashControl { get; set; }
        string InvoiceDate { get; set; }
        string InvoiceNo { get; set; }
        string InvoiceType { get; set; }
        List<Line> Line { get; set; }
        string MovementEndTime { get; set; }
        string MovementStartTime { get; set; }
        string Period { get; set; }
        ShipFrom ShipFrom { get; set; }
        ShipTo ShipTo { get; set; }
        string SourceID { get; set; }
        SpecialRegimes SpecialRegimes { get; set; }
        string SystemEntryDate { get; set; }
        string TransactionID { get; set; }
        WithholdingTax WithholdingTax { get; set; }
    }
}