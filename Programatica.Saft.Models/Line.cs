using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Line", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Line : ILine
    {
        [XmlElement(ElementName = "LineNumber", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string LineNumber { get; set; }
        [XmlElement(ElementName = "ProductCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ProductCode { get; set; }
        [XmlElement(ElementName = "ProductDescription", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ProductDescription { get; set; }
        [XmlElement(ElementName = "Quantity", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Quantity { get; set; }
        [XmlElement(ElementName = "UnitOfMeasure", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string UnitOfMeasure { get; set; }
        [XmlElement(ElementName = "UnitPrice", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string UnitPrice { get; set; }
        [XmlElement(ElementName = "TaxPointDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxPointDate { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Description { get; set; }
        [XmlElement(ElementName = "ProductSerialNumber", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public ProductSerialNumber ProductSerialNumber { get; set; }
        [XmlElement(ElementName = "CreditAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CreditAmount { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public Tax Tax { get; set; }
        [XmlElement(ElementName = "OrderReferences", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<OrderReferences> OrderReferences { get; set; }
        [XmlElement(ElementName = "SettlementAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SettlementAmount { get; set; }
        [XmlElement(ElementName = "TaxExemptionReason", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxExemptionReason { get; set; }
        [XmlElement(ElementName = "TaxExemptionCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxExemptionCode { get; set; }
        [XmlElement(ElementName = "References", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<References> References { get; set; }
        [XmlElement(ElementName = "DebitAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string DebitAmount { get; set; }
        [XmlElement(ElementName = "CustomsInformation", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public CustomsInformation CustomsInformation { get; set; }
        [XmlElement(ElementName = "TaxBase", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxBase { get; set; }
        [XmlElement(ElementName = "SourceDocumentID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SourceDocumentID { get; set; }
    }
}
