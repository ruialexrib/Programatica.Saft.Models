namespace Programatica.Saft.Models
{
    public interface IAuditFile
    {
        GeneralLedgerEntries GeneralLedgerEntries { get; set; }
        Header Header { get; set; }
        MasterFiles MasterFiles { get; set; }
        string SchemaLocation { get; set; }
        SourceDocuments SourceDocuments { get; set; }
        string Xmlns { get; set; }
        string Xsi { get; set; }
    }
}