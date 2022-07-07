using System.Xml.Serialization;

namespace DesignPatterns2.cap8
{
    public class GeradorDeXml
    {
        private object? cliente;

        public string GeraXml(object o)
        {
            var serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);
            String xml = writer.ToString();
            return xml;
        }
    }
}