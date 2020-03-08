using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IStockMovement
    {
        string ATCUD { get; set; }
        string ATDocCodeID { get; set; }
        string CustomerID { get; set; }
        string DocumentNumber { get; set; }
        DocumentStatus DocumentStatus { get; set; }
        DocumentTotals DocumentTotals { get; set; }
        string EACCode { get; set; }
        string Hash { get; set; }
        string HashControl { get; set; }
        List<Line> Line { get; set; }
        string MovementComments { get; set; }
        string MovementDate { get; set; }
        string MovementEndTime { get; set; }
        string MovementStartTime { get; set; }
        string MovementType { get; set; }
        string Period { get; set; }
        ShipFrom ShipFrom { get; set; }
        ShipTo ShipTo { get; set; }
        string SourceID { get; set; }
        string SupplierID { get; set; }
        string SystemEntryDate { get; set; }
        string TransactionID { get; set; }
    }
}