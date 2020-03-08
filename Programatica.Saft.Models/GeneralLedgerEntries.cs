using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "GeneralLedgerEntries", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class GeneralLedgerEntries : IGeneralLedgerEntries
    {
        [XmlElement(ElementName = "NumberOfEntries", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string NumberOfEntries { get; set; }
        [XmlElement(ElementName = "TotalDebit", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TotalDebit { get; set; }
        [XmlElement(ElementName = "TotalCredit", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TotalCredit { get; set; }
        [XmlElement(ElementName = "Journal", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Journal> Journal { get; set; }
    }
}
