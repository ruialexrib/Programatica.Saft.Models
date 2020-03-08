using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "PaymentMethod", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class PaymentMethod : IPaymentMethod
    {
        [XmlElement(ElementName = "PaymentMechanism", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentMechanism { get; set; }
        [XmlElement(ElementName = "PaymentAmount", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentAmount { get; set; }
        [XmlElement(ElementName = "PaymentDate", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public string PaymentDate { get; set; }
    }
}
