using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "AuditFile", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class AuditFile
    {
        [XmlElement(ElementName = "Header", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "MasterFiles", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public MasterFiles MasterFiles { get; set; }
        [XmlElement(ElementName = "GeneralLedgerEntries", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public GeneralLedgerEntries GeneralLedgerEntries { get; set; }
        [XmlElement(ElementName = "SourceDocuments", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public SourceDocuments SourceDocuments { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
