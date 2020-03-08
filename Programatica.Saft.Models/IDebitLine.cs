namespace Programatica.Saft.Models
{
    public interface IDebitLine
    {
        string AccountID { get; set; }
        string DebitAmount { get; set; }
        string Description { get; set; }
        string RecordID { get; set; }
        string SystemEntryDate { get; set; }
    }
}