using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Lines", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Lines : ILines
    {
        [XmlElement(ElementName = "DebitLine", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<DebitLine> DebitLine { get; set; }
        [XmlElement(ElementName = "CreditLine", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<CreditLine> CreditLine { get; set; }
    }
}
