namespace Programatica.Saft.Models
{
    public interface IWorkDocument
    {
        string ATCUD { get; set; }
        string CustomerID { get; set; }
        string DocumentNumber { get; set; }
        DocumentStatus DocumentStatus { get; set; }
        DocumentTotals DocumentTotals { get; set; }
        string EACCode { get; set; }
        string Hash { get; set; }
        string HashControl { get; set; }
        Line Line { get; set; }
        string Period { get; set; }
        string SourceID { get; set; }
        string SystemEntryDate { get; set; }
        string TransactionID { get; set; }
        string WorkDate { get; set; }
        string WorkType { get; set; }
    }
}