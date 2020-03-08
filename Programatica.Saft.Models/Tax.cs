using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Tax", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Tax : ITax
    {
        [XmlElement(ElementName = "TaxType", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxType { get; set; }
        [XmlElement(ElementName = "TaxCountryRegion", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxCountryRegion { get; set; }
        [XmlElement(ElementName = "TaxCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxCode { get; set; }
        [XmlElement(ElementName = "TaxPercentage", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxPercentage { get; set; }
    }
}
