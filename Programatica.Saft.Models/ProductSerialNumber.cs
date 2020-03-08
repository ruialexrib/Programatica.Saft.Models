using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "ProductSerialNumber", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class ProductSerialNumber : IProductSerialNumber
    {
        [XmlElement(ElementName = "SerialNumber", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SerialNumber { get; set; }
    }
}
