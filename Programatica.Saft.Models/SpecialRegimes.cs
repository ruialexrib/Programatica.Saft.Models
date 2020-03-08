using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "SpecialRegimes", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class SpecialRegimes : ISpecialRegimes
    {
        [XmlElement(ElementName = "SelfBillingIndicator", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string SelfBillingIndicator { get; set; }
        [XmlElement(ElementName = "CashVATSchemeIndicator", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string CashVATSchemeIndicator { get; set; }
        [XmlElement(ElementName = "ThirdPartiesBillingIndicator", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string ThirdPartiesBillingIndicator { get; set; }
    }
}
