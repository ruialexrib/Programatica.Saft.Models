namespace Programatica.Saft.Models
{
    public interface ISourceDocuments
    {
        MovementOfGoods MovementOfGoods { get; set; }
        Payments Payments { get; set; }
        SalesInvoices SalesInvoices { get; set; }
        WorkingDocuments WorkingDocuments { get; set; }
    }
}