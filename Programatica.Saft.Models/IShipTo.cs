using System.Collections.Generic;

namespace Programatica.Saft.Models
{
    public interface IShipTo
    {
        Address Address { get; set; }
        string DeliveryDate { get; set; }
        string DeliveryID { get; set; }
        List<string> LocationID { get; set; }
        string WarehouseID { get; set; }
    }
}