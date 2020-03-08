using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "SourceDocuments", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class SourceDocuments : ISourceDocuments
    {
        [XmlElement(ElementName = "SalesInvoices", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public SalesInvoices SalesInvoices { get; set; }
        [XmlElement(ElementName = "MovementOfGoods", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public MovementOfGoods MovementOfGoods { get; set; }
        [XmlElement(ElementName = "WorkingDocuments", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public WorkingDocuments WorkingDocuments { get; set; }
        [XmlElement(ElementName = "Payments", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public Payments Payments { get; set; }
    }
}
