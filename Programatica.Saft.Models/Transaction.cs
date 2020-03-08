using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Transaction", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Transaction : ITransaction
    {
        [XmlElement(ElementName = "TransactionID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TransactionID { get; set; }
        [XmlElement(ElementName = "Period", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Period { get; set; }
        [XmlElement(ElementName = "TransactionDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TransactionDate { get; set; }
        [XmlElement(ElementName = "SourceID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SourceID { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Description { get; set; }
        [XmlElement(ElementName = "DocArchivalNumber", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string DocArchivalNumber { get; set; }
        [XmlElement(ElementName = "TransactionType", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TransactionType { get; set; }
        [XmlElement(ElementName = "GLPostingDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string GLPostingDate { get; set; }
        [XmlElement(ElementName = "CustomerID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CustomerID { get; set; }
        [XmlElement(ElementName = "Lines", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public Lines Lines { get; set; }
        [XmlElement(ElementName = "SupplierID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SupplierID { get; set; }
    }
}
