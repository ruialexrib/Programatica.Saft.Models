using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IDocumentTotals
    {
        Currency Currency { get; set; }
        string GrossTotal { get; set; }
        string NetTotal { get; set; }
        List<Payment> Payment { get; set; }
        List<Settlement> Settlement { get; set; }
        string TaxPayable { get; set; }
    }
}