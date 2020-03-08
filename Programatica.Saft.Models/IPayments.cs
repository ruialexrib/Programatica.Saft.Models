using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IPayments
    {
        string NumberOfEntries { get; set; }
        List<Payment> Payment { get; set; }
        string TotalCredit { get; set; }
        string TotalDebit { get; set; }
    }
}