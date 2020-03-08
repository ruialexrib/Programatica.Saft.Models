using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IMasterFiles
    {
        List<Customer> Customer { get; set; }
        GeneralLedgerAccounts GeneralLedgerAccounts { get; set; }
        List<Product> Product { get; set; }
        List<Supplier> Supplier { get; set; }
        TaxTable TaxTable { get; set; }
    }
}