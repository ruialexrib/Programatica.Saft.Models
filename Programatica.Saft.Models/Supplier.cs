using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Supplier", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Supplier : ISupplier
    {
        [XmlElement(ElementName = "SupplierID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SupplierID { get; set; }
        [XmlElement(ElementName = "AccountID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string AccountID { get; set; }
        [XmlElement(ElementName = "SupplierTaxID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SupplierTaxID { get; set; }
        [XmlElement(ElementName = "CompanyName", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CompanyName { get; set; }
        [XmlElement(ElementName = "Contact", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Contact { get; set; }
        [XmlElement(ElementName = "BillingAddress", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public BillingAddress BillingAddress { get; set; }
        [XmlElement(ElementName = "ShipFromAddress", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public ShipFromAddress ShipFromAddress { get; set; }
        [XmlElement(ElementName = "Telephone", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Telephone { get; set; }
        [XmlElement(ElementName = "Fax", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "SelfBillingIndicator", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SelfBillingIndicator { get; set; }
        [XmlElement(ElementName = "Email", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Email { get; set; }
    }
}
