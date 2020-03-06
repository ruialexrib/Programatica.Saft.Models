using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Programatica.Saft.Models
{
    [XmlRoot(ElementName = "TaxTable", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
    public class TaxTable
    {
        [XmlElement(ElementName = "TaxTableEntry", Namespace = "urn:OECD:StandardAuditFile-Tax:PT_1.04_01")]
        public List<TaxTableEntry> TaxTableEntry { get; set; }
    }
}
