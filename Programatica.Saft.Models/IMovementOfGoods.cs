using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IMovementOfGoods
    {
        string NumberOfMovementLines { get; set; }
        List<StockMovement> StockMovement { get; set; }
        string TotalQuantityIssued { get; set; }
    }
}