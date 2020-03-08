using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface ILines
    {
        List<CreditLine> CreditLine { get; set; }
        List<DebitLine> DebitLine { get; set; }
    }
}