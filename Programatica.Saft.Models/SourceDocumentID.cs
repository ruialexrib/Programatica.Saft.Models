using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "SourceDocumentID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class SourceDocumentID
    {
        [XmlElement(ElementName = "OriginatingON", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string OriginatingON { get; set; }
        [XmlElement(ElementName = "InvoiceDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string InvoiceDate { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Description { get; set; }
    }
}
