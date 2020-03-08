using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Journal", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Journal : IJournal
    {
        [XmlElement(ElementName = "JournalID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string JournalID { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Description { get; set; }
        [XmlElement(ElementName = "Transaction", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Transaction> Transaction { get; set; }
    }
}
