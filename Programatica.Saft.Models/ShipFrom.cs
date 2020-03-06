using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "ShipFrom", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class ShipFrom
    {
        [XmlElement(ElementName = "DeliveryID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string DeliveryID { get; set; }
        [XmlElement(ElementName = "DeliveryDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string DeliveryDate { get; set; }
        [XmlElement(ElementName = "WarehouseID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<string> WarehouseID { get; set; }
        [XmlElement(ElementName = "LocationID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<string> LocationID { get; set; }
        [XmlElement(ElementName = "Address", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public Address Address { get; set; }
    }
}
