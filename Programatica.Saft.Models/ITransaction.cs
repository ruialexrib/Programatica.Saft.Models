namespace Programatica.Saft.Models
{
    public interface ITransaction
    {
        string CustomerID { get; set; }
        string Description { get; set; }
        string DocArchivalNumber { get; set; }
        string GLPostingDate { get; set; }
        Lines Lines { get; set; }
        string Period { get; set; }
        string SourceID { get; set; }
        string SupplierID { get; set; }
        string TransactionDate { get; set; }
        string TransactionID { get; set; }
        string TransactionType { get; set; }
    }
}