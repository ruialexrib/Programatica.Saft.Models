namespace Programatica.Saft.Models
{
    public interface ISettlement
    {
        string PaymentTerms { get; set; }
        string SettlementAmount { get; set; }
        string SettlementDate { get; set; }
        string SettlementDiscount { get; set; }
    }
}