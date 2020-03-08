using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "ShipToAddress", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class ShipToAddress : IShipToAddress
    {
        [XmlElement(ElementName = "AddressDetail", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string AddressDetail { get; set; }
        [XmlElement(ElementName = "City", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string City { get; set; }
        [XmlElement(ElementName = "PostalCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Country { get; set; }
    }
}
