// <copyright file="ProtobufSerializer.cs" company="Computer Technology Solutions, Inc.">
// Copyright (c) 2011 Computer Technology Solutions, Inc.  ALL RIGHTS RESERVED
// </copyright>
// <author>jvance</author>
// <date>9/2/2011 9:38:01 PM</date>
// <productName></productName>
namespace LightWcf
{
    using System.IO;
    using ProtoBuf;

    /// <summary>
    /// Summary description for ProtobufSerializer
    /// </summary>
    public class ProtobufSerializer : ISerializer
    {
        public void Serialize<T>(Stream dest, T dto)
        {
            Serializer.Serialize(dest, dto);
        }

        public T Deserialize<T>(Stream source)
        {
            return Serializer.Deserialize<T>(source);
        }
    }
}
