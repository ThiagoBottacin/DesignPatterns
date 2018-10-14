using System.IO;
using System.Text;
using System.Xml;
using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    public class FormatoXml : IFormato
    {
        public IFormato Proximo { get; set; }

        public string Formatar(Requisicao requisicao, ContaBancaria conta)
        {
            if (requisicao.Formato == Formato.XML)
            {
                XmlWriterSettings xmlSettings = new XmlWriterSettings
                {
                    Indent = true,
                    OmitXmlDeclaration = true,
                    Encoding = Encoding.UTF8
                };

                using (StringWriter sw = new StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(sw, xmlSettings))
                    {
                        writer.WriteStartDocument();

                        writer.WriteStartElement("Conta");
                        writer.WriteElementString("NomeTitular", conta.NomeTitular);
                        writer.WriteElementString("Saldo", conta.Saldo.ToString("N"));
                        writer.WriteEndElement();

                        writer.WriteEndDocument();
                    }

                    return sw.ToString();
                }
            }

            return Proximo.Formatar(requisicao, conta);
        }
    }
}
