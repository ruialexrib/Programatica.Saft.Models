using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "TaxTableEntry", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class TaxTableEntry : ITaxTableEntry
    {
        [XmlElement(ElementName = "TaxType", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxType { get; set; }
        [XmlElement(ElementName = "TaxCountryRegion", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxCountryRegion { get; set; }
        [XmlElement(ElementName = "TaxCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxCode { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Description { get; set; }
        [XmlElement(ElementName = "TaxPercentage", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxPercentage { get; set; }
        [XmlElement(ElementName = "TaxAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxAmount { get; set; }
        [XmlElement(ElementName = "TaxExpirationDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxExpirationDate { get; set; }
    }
}
