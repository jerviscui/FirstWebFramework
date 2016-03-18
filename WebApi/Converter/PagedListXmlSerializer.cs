using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WebApi.Converter
{
    public class PagedListXmlSerializer : XmlObjectSerializer
    {
        /// <summary>
        /// Writes the start of the object's data as an opening XML element using the specified <see cref="T:System.Xml.XmlDictionaryWriter"/>.
        /// </summary>
        /// <param name="writer">An <see cref="T:System.Xml.XmlDictionaryWriter"/> used to write the XML document.</param><param name="graph">The object to serialize.</param><exception cref="T:System.Runtime.Serialization.InvalidDataContractException">the type being serialized does not conform to data contract rules. For example, the <see cref="T:System.Runtime.Serialization.DataContractAttribute"/> attribute has not been applied to the type.</exception><exception cref="T:System.Runtime.Serialization.SerializationException">there is a problem with the instance being serialized.</exception><exception cref="T:System.ServiceModel.QuotaExceededException">the maximum number of objects to serialize has been exceeded. Check the <see cref="P:System.Runtime.Serialization.DataContractSerializer.MaxItemsInObjectGraph"/> property.</exception>
        public override void WriteStartObject(XmlDictionaryWriter writer, object graph)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Writes only the content of the object to the XML document or stream using the specified <see cref="T:System.Xml.XmlDictionaryWriter"/>.
        /// </summary>
        /// <param name="writer">An <see cref="T:System.Xml.XmlDictionaryWriter"/> used to write the XML document or stream.</param><param name="graph">The object that contains the content to write.</param><exception cref="T:System.Runtime.Serialization.InvalidDataContractException">the type being serialized does not conform to data contract rules. For example, the <see cref="T:System.Runtime.Serialization.DataContractAttribute"/> attribute has not been applied to the type.</exception><exception cref="T:System.Runtime.Serialization.SerializationException">there is a problem with the instance being serialized.</exception><exception cref="T:System.ServiceModel.QuotaExceededException">the maximum number of objects to serialize has been exceeded. Check the <see cref="P:System.Runtime.Serialization.DataContractSerializer.MaxItemsInObjectGraph"/> property.</exception>
        public override void WriteObjectContent(XmlDictionaryWriter writer, object graph)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Writes the end of the object data as a closing XML element to the XML document or stream with an <see cref="T:System.Xml.XmlDictionaryWriter"/>.
        /// </summary>
        /// <param name="writer">An <see cref="T:System.Xml.XmlDictionaryWriter"/> used to write the XML document or stream.</param><exception cref="T:System.Runtime.Serialization.InvalidDataContractException">the type being serialized does not conform to data contract rules. For example, the <see cref="T:System.Runtime.Serialization.DataContractAttribute"/> attribute has not been applied to the type.</exception><exception cref="T:System.Runtime.Serialization.SerializationException">there is a problem with the instance being serialized.</exception><exception cref="T:System.ServiceModel.QuotaExceededException">the maximum number of objects to serialize has been exceeded. Check the <see cref="P:System.Runtime.Serialization.DataContractSerializer.MaxItemsInObjectGraph"/> property.</exception>
        public override void WriteEndObject(XmlDictionaryWriter writer)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Reads the XML stream or document with an <see cref="T:System.Xml.XmlDictionaryReader"/> and returns the deserialized object; it also enables you to specify whether the serializer can read the data before attempting to read it.
        /// </summary>
        /// <returns>
        /// The deserialized object.
        /// </returns>
        /// <param name="reader">An <see cref="T:System.Xml.XmlDictionaryReader"/> used to read the XML document.</param><param name="verifyObjectName">true to check whether the enclosing XML element name and namespace correspond to the root name and root namespace; otherwise, false to skip the verification.</param>
        public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a value that specifies whether the <see cref="T:System.Xml.XmlDictionaryReader"/> is positioned over an XML element that can be read.
        /// </summary>
        /// <returns>
        /// true if the reader can read the data; otherwise, false.
        /// </returns>
        /// <param name="reader">An <see cref="T:System.Xml.XmlDictionaryReader"/> used to read the XML stream or document.</param>
        public override bool IsStartObject(XmlDictionaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
