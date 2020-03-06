using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Payment", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Payment
    {
        [XmlElement(ElementName = "PaymentMechanism", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentMechanism { get; set; }
        [XmlElement(ElementName = "PaymentAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentAmount { get; set; }
        [XmlElement(ElementName = "PaymentDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentDate { get; set; }
        [XmlElement(ElementName = "PaymentRefNo", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentRefNo { get; set; }
        [XmlElement(ElementName = "ATCUD", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ATCUD { get; set; }
        [XmlElement(ElementName = "Period", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Period { get; set; }
        [XmlElement(ElementName = "TransactionID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TransactionID { get; set; }
        [XmlElement(ElementName = "TransactionDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TransactionDate { get; set; }
        [XmlElement(ElementName = "PaymentType", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentType { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Description { get; set; }
        [XmlElement(ElementName = "SystemID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SystemID { get; set; }
        [XmlElement(ElementName = "DocumentStatus", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public DocumentStatus DocumentStatus { get; set; }
        [XmlElement(ElementName = "PaymentMethod", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<PaymentMethod> PaymentMethod { get; set; }
        [XmlElement(ElementName = "SourceID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SourceID { get; set; }
        [XmlElement(ElementName = "SystemEntryDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SystemEntryDate { get; set; }
        [XmlElement(ElementName = "CustomerID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CustomerID { get; set; }
        [XmlElement(ElementName = "Line", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Line> Line { get; set; }
        [XmlElement(ElementName = "DocumentTotals", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public DocumentTotals DocumentTotals { get; set; }
        [XmlElement(ElementName = "WithholdingTax", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public WithholdingTax WithholdingTax { get; set; }
    }
}
