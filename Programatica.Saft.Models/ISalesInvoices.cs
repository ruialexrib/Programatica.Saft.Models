using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface ISalesInvoices
    {
        List<Invoice> Invoice { get; set; }
        string NumberOfEntries { get; set; }
        string TotalCredit { get; set; }
        string TotalDebit { get; set; }
    }
}