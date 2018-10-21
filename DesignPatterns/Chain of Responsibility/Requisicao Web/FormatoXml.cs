using System;
using System.IO;
using System.Text;
using System.Xml;
using DesignPatterns.Strategy;

namespace DesignPatterns.Chain_of_Responsibility.Requisicao_Web
{
    class FormatoXml : IFormato
    {
        public IFormato Proximo { get; private set; }

        public FormatoXml(IFormato proximo)
        {
            Proximo = proximo;
        }

        public FormatoXml()
        {
            Proximo = null;
        }

        public string Formatar(Requisicao requisicao, Conta conta)
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
                        writer.WriteElementString("NomeTitular", conta.Nome);
                        writer.WriteElementString("Saldo", conta.Saldo.ToString("N"));
                        writer.WriteEndElement();

                        writer.WriteEndDocument();
                    }

                    return sw.ToString();
                }
            }

            return Proximo?.Formatar(requisicao, conta) ?? throw new Exception("Formato de resposta não encontrado");
        }
    }
}
