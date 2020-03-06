using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "OrderReferences", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class OrderReferences
    {
        [XmlElement(ElementName = "OriginatingON", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string OriginatingON { get; set; }
        [XmlElement(ElementName = "OrderDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string OrderDate { get; set; }
    }
}
