using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Invoice", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Invoice : IInvoice
    {
        [XmlElement(ElementName = "InvoiceNo", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string InvoiceNo { get; set; }
        [XmlElement(ElementName = "ATCUD", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ATCUD { get; set; }
        [XmlElement(ElementName = "DocumentStatus", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public DocumentStatus DocumentStatus { get; set; }
        [XmlElement(ElementName = "Hash", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Hash { get; set; }
        [XmlElement(ElementName = "HashControl", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string HashControl { get; set; }
        [XmlElement(ElementName = "Period", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Period { get; set; }
        [XmlElement(ElementName = "InvoiceDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string InvoiceDate { get; set; }
        [XmlElement(ElementName = "InvoiceType", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string InvoiceType { get; set; }
        [XmlElement(ElementName = "SpecialRegimes", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public SpecialRegimes SpecialRegimes { get; set; }
        [XmlElement(ElementName = "SourceID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SourceID { get; set; }
        [XmlElement(ElementName = "EACCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string EACCode { get; set; }
        [XmlElement(ElementName = "SystemEntryDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SystemEntryDate { get; set; }
        [XmlElement(ElementName = "TransactionID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TransactionID { get; set; }
        [XmlElement(ElementName = "CustomerID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CustomerID { get; set; }
        [XmlElement(ElementName = "ShipTo", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public ShipTo ShipTo { get; set; }
        [XmlElement(ElementName = "ShipFrom", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public ShipFrom ShipFrom { get; set; }
        [XmlElement(ElementName = "MovementEndTime", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string MovementEndTime { get; set; }
        [XmlElement(ElementName = "MovementStartTime", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string MovementStartTime { get; set; }
        [XmlElement(ElementName = "Line", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Line> Line { get; set; }
        [XmlElement(ElementName = "DocumentTotals", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public DocumentTotals DocumentTotals { get; set; }
        [XmlElement(ElementName = "WithholdingTax", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public WithholdingTax WithholdingTax { get; set; }
    }
}
