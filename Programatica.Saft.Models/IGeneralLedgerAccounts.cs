using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IGeneralLedgerAccounts
    {
        List<Account> Account { get; set; }
        string TaxonomyReference { get; set; }
    }
}