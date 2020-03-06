using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "GeneralLedgerAccounts", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class GeneralLedgerAccounts
    {
        [XmlElement(ElementName = "TaxonomyReference", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string TaxonomyReference { get; set; }
        [XmlElement(ElementName = "Account", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<Account> Account { get; set; }
    }
}
