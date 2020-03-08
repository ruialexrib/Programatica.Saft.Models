using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "Header", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class Header : IHeader
    {
        [XmlElement(ElementName = "AuditFileVersion", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string AuditFileVersion { get; set; }
        [XmlElement(ElementName = "CompanyID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CompanyID { get; set; }
        [XmlElement(ElementName = "TaxRegistrationNumber", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxRegistrationNumber { get; set; }
        [XmlElement(ElementName = "TaxAccountingBasis", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxAccountingBasis { get; set; }
        [XmlElement(ElementName = "CompanyName", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CompanyName { get; set; }
        [XmlElement(ElementName = "BusinessName", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string BusinessName { get; set; }
        [XmlElement(ElementName = "CompanyAddress", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public CompanyAddress CompanyAddress { get; set; }
        [XmlElement(ElementName = "FiscalYear", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string FiscalYear { get; set; }
        [XmlElement(ElementName = "StartDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string StartDate { get; set; }
        [XmlElement(ElementName = "EndDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string EndDate { get; set; }
        [XmlElement(ElementName = "CurrencyCode", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "DateCreated", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string DateCreated { get; set; }
        [XmlElement(ElementName = "TaxEntity", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxEntity { get; set; }
        [XmlElement(ElementName = "ProductCompanyTaxID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ProductCompanyTaxID { get; set; }
        [XmlElement(ElementName = "SoftwareCertificateNumber", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SoftwareCertificateNumber { get; set; }
        [XmlElement(ElementName = "ProductID", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ProductID { get; set; }
        [XmlElement(ElementName = "ProductVersion", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ProductVersion { get; set; }
        [XmlElement(ElementName = "HeaderComment", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string HeaderComment { get; set; }
        [XmlElement(ElementName = "Telephone", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Telephone { get; set; }
        [XmlElement(ElementName = "Fax", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "Email", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Email { get; set; }
        [XmlElement(ElementName = "Website", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string Website { get; set; }
    }
}
