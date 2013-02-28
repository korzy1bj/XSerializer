﻿using System.Xml;
using System.Xml.Serialization;

namespace XSerializer
{
    public interface IXmlSerializer
    {
        void SerializeObject(SerializationXmlTextWriter writer, object instance, XmlSerializerNamespaces namespaces);
        object DeserializeObject(XmlReader reader);
    }

    public interface IXmlSerializer<T> : IXmlSerializer
    {
        void Serialize(SerializationXmlTextWriter writer, T instance, XmlSerializerNamespaces namespaces);
        T Deserialize(XmlReader reader);
    }
}