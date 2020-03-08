namespace Programatica.Saft.Models
{
    public interface ISourceDocumentID
    {
        string Description { get; set; }
        string InvoiceDate { get; set; }
        string OriginatingON { get; set; }
    }
}