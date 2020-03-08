namespace Programatica.Saft.Models
{
    public interface ICurrency
    {
        string CurrencyAmount { get; set; }
        string CurrencyCode { get; set; }
        string ExchangeRate { get; set; }
    }
}