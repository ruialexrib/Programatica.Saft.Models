using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "References", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class References
    {
        [XmlElement(ElementName = "Reference", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Reference { get; set; }
        [XmlElement(ElementName = "Reason", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Reason { get; set; }
    }
}
