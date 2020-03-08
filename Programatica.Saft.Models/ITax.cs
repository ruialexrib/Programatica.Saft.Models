namespace Programatica.Saft.Models
{
    public interface ITax
    {
        string TaxCode { get; set; }
        string TaxCountryRegion { get; set; }
        string TaxPercentage { get; set; }
        string TaxType { get; set; }
    }
}