using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface ILine
    {
        string CreditAmount { get; set; }
        CustomsInformation CustomsInformation { get; set; }
        string DebitAmount { get; set; }
        string Description { get; set; }
        string LineNumber { get; set; }
        List<OrderReferences> OrderReferences { get; set; }
        string ProductCode { get; set; }
        string ProductDescription { get; set; }
        ProductSerialNumber ProductSerialNumber { get; set; }
        string Quantity { get; set; }
        List<References> References { get; set; }
        string SettlementAmount { get; set; }
        string SourceDocumentID { get; set; }
        Tax Tax { get; set; }
        string TaxBase { get; set; }
        string TaxExemptionCode { get; set; }
        string TaxExemptionReason { get; set; }
        string TaxPointDate { get; set; }
        string UnitOfMeasure { get; set; }
        string UnitPrice { get; set; }
    }
}