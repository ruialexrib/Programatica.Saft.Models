using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Settlement", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Settlement
    {
        [XmlElement(ElementName = "SettlementDiscount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SettlementDiscount { get; set; }
        [XmlElement(ElementName = "SettlementAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SettlementAmount { get; set; }
        [XmlElement(ElementName = "SettlementDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SettlementDate { get; set; }
        [XmlElement(ElementName = "PaymentTerms", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentTerms { get; set; }
    }
}
