using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Currency", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Currency
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "CurrencyAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CurrencyAmount { get; set; }
        [XmlElement(ElementName = "ExchangeRate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ExchangeRate { get; set; }
    }
}
