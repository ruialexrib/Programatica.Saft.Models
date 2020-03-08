using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IWorkingDocuments
    {
        string NumberOfEntries { get; set; }
        string TotalCredit { get; set; }
        string TotalDebit { get; set; }
        List<WorkDocument> WorkDocument { get; set; }
    }
}