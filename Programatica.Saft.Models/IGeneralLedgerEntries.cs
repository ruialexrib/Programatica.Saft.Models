using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IGeneralLedgerEntries
    {
        List<Journal> Journal { get; set; }
        string NumberOfEntries { get; set; }
        string TotalCredit { get; set; }
        string TotalDebit { get; set; }
    }
}