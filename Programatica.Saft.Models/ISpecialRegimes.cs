namespace Programatica.Saft.Models
{
    public interface ISpecialRegimes
    {
        string CashVATSchemeIndicator { get; set; }
        string SelfBillingIndicator { get; set; }
        string ThirdPartiesBillingIndicator { get; set; }
    }
}