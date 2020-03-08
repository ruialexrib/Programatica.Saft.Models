using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "MasterFiles", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class MasterFiles : IMasterFiles
    {
        [XmlElement(ElementName = "GeneralLedgerAccounts", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public GeneralLedgerAccounts GeneralLedgerAccounts { get; set; }
        [XmlElement(ElementName = "Customer", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Customer> Customer { get; set; }
        [XmlElement(ElementName = "Supplier", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Supplier> Supplier { get; set; }
        [XmlElement(ElementName = "Product", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Product> Product { get; set; }
        [XmlElement(ElementName = "TaxTable", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public TaxTable TaxTable { get; set; }
    }
}
