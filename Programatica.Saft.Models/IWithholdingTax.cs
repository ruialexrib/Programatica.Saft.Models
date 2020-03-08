namespace Programatica.Saft.Models
{
    public interface IWithholdingTax
    {
        string WithholdingTaxAmount { get; set; }
        string WithholdingTaxDescription { get; set; }
        string WithholdingTaxType { get; set; }
    }
}