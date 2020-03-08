using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "MovementOfGoods", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class MovementOfGoods : IMovementOfGoods
    {
        [XmlElement(ElementName = "NumberOfMovementLines", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string NumberOfMovementLines { get; set; }
        [XmlElement(ElementName = "TotalQuantityIssued", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TotalQuantityIssued { get; set; }
        [XmlElement(ElementName = "StockMovement", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<StockMovement> StockMovement { get; set; }
    }
}
