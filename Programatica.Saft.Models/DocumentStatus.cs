using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "DocumentStatus", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class DocumentStatus : IDocumentStatus
    {
        [XmlElement(ElementName = "InvoiceStatus", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string InvoiceStatus { get; set; }
        [XmlElement(ElementName = "InvoiceStatusDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string InvoiceStatusDate { get; set; }
        [XmlElement(ElementName = "SourceID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SourceID { get; set; }
        [XmlElement(ElementName = "SourceBilling", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SourceBilling { get; set; }
        [XmlElement(ElementName = "Reason", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Reason { get; set; }
        [XmlElement(ElementName = "MovementStatus", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string MovementStatus { get; set; }
        [XmlElement(ElementName = "MovementStatusDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string MovementStatusDate { get; set; }
        [XmlElement(ElementName = "WorkStatus", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string WorkStatus { get; set; }
        [XmlElement(ElementName = "WorkStatusDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string WorkStatusDate { get; set; }
        [XmlElement(ElementName = "PaymentStatus", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentStatus { get; set; }
        [XmlElement(ElementName = "PaymentStatusDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentStatusDate { get; set; }
        [XmlElement(ElementName = "SourcePayment", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SourcePayment { get; set; }
    }
}
