using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "DocumentTotals", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class DocumentTotals : IDocumentTotals
    {
        [XmlElement(ElementName = "TaxPayable", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxPayable { get; set; }
        [XmlElement(ElementName = "NetTotal", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string NetTotal { get; set; }
        [XmlElement(ElementName = "GrossTotal", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string GrossTotal { get; set; }
        [XmlElement(ElementName = "Currency", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public Currency Currency { get; set; }
        [XmlElement(ElementName = "Settlement", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Settlement> Settlement { get; set; }
        [XmlElement(ElementName = "Payment", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Payment> Payment { get; set; }
    }
}
