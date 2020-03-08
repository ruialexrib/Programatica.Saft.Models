namespace Programatica.Saft.Models
{
    public interface IDocumentStatus
    {
        string InvoiceStatus { get; set; }
        string InvoiceStatusDate { get; set; }
        string MovementStatus { get; set; }
        string MovementStatusDate { get; set; }
        string PaymentStatus { get; set; }
        string PaymentStatusDate { get; set; }
        string Reason { get; set; }
        string SourceBilling { get; set; }
        string SourceID { get; set; }
        string SourcePayment { get; set; }
        string WorkStatus { get; set; }
        string WorkStatusDate { get; set; }
    }
}