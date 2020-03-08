namespace Programatica.Saft.Models
{
    public interface ITaxTableEntry
    {
        string Description { get; set; }
        string TaxAmount { get; set; }
        string TaxCode { get; set; }
        string TaxCountryRegion { get; set; }
        string TaxExpirationDate { get; set; }
        string TaxPercentage { get; set; }
        string TaxType { get; set; }
    }
}