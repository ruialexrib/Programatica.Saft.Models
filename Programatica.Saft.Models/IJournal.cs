using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IJournal
    {
        string Description { get; set; }
        string JournalID { get; set; }
        List<Transaction> Transaction { get; set; }
    }
}