using System.IO;
using System.Xml.Serialization;

namespace Programatica.Saft.Models.Extensions
{
    public static class AuditFileExtensions
    {
        public static AuditFile FromXml(this AuditFile auditFile, string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AuditFile));
            using (TextReader reader = new StringReader(xml))
            {
                auditFile = (AuditFile)serializer.Deserialize(reader);
                return auditFile;
            }

        }
    }
}
