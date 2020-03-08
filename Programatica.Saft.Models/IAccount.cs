namespace Programatica.Saft.Models
{
    public interface IAccount
    {
        string AccountDescription { get; set; }
        string AccountID { get; set; }
        string ClosingCreditBalance { get; set; }
        string ClosingDebitBalance { get; set; }
        string GroupingCategory { get; set; }
        string GroupingCode { get; set; }
        string OpeningCreditBalance { get; set; }
        string OpeningDebitBalance { get; set; }
        string TaxonomyCode { get; set; }
    }
}