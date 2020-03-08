using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "WithholdingTax", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class WithholdingTax : IWithholdingTax
    {
        [XmlElement(ElementName = "WithholdingTaxType", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string WithholdingTaxType { get; set; }
        [XmlElement(ElementName = "WithholdingTaxDescription", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string WithholdingTaxDescription { get; set; }
        [XmlElement(ElementName = "WithholdingTaxAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string WithholdingTaxAmount { get; set; }
    }
}
