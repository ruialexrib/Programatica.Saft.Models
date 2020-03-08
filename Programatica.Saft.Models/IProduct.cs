namespace Programatica.Saft.Models
{
    public interface IProduct
    {
        CustomsDetails CustomsDetails { get; set; }
        string ProductCode { get; set; }
        string ProductDescription { get; set; }
        string ProductGroup { get; set; }
        string ProductNumberCode { get; set; }
        string ProductType { get; set; }
    }
}