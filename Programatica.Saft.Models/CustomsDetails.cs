using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "CustomsDetails", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class CustomsDetails
    {
        [XmlElement(ElementName = "CNCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CNCode { get; set; }
        [XmlElement(ElementName = "UNNumber", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string UNNumber { get; set; }
    }
}
