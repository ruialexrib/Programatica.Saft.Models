using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IShipFrom
    {
        Address Address { get; set; }
        string DeliveryDate { get; set; }
        string DeliveryID { get; set; }
        List<string> LocationID { get; set; }
        List<string> WarehouseID { get; set; }
    }
}