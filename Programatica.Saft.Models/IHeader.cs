namespace Programatica.Saft.Models
{
    public interface IHeader
    {
        string AuditFileVersion { get; set; }
        string BusinessName { get; set; }
        CompanyAddress CompanyAddress { get; set; }
        string CompanyID { get; set; }
        string CompanyName { get; set; }
        string CurrencyCode { get; set; }
        string DateCreated { get; set; }
        string Email { get; set; }
        string EndDate { get; set; }
        string Fax { get; set; }
        string FiscalYear { get; set; }
        string HeaderComment { get; set; }
        string ProductCompanyTaxID { get; set; }
        string ProductID { get; set; }
        string ProductVersion { get; set; }
        string SoftwareCertificateNumber { get; set; }
        string StartDate { get; set; }
        string TaxAccountingBasis { get; set; }
        string TaxEntity { get; set; }
        string TaxRegistrationNumber { get; set; }
        string Telephone { get; set; }
        string Website { get; set; }
    }
}