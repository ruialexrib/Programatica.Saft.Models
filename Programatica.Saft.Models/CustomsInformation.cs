using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "CustomsInformation", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class CustomsInformation
    {
        [XmlElement(ElementName = "IECAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string IECAmount { get; set; }
        [XmlElement(ElementName = "ARCNo", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ARCNo { get; set; }
    }
}
