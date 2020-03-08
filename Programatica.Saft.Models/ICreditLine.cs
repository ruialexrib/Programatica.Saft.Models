namespace Programatica.Saft.Models
{
    public interface ICreditLine
    {
        string AccountID { get; set; }
        string CreditAmount { get; set; }
        string Description { get; set; }
        string RecordID { get; set; }
        string SystemEntryDate { get; set; }
    }
}