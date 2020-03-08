using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface ITaxTable
    {
        List<TaxTableEntry> TaxTableEntry { get; set; }
    }
}