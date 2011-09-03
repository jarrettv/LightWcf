﻿using System.IO;
using System.Net;
using ProtoBuf;

namespace LightWcf
{
    /// <summary>
    /// Utility methods to make WebClient easier to use with HTTP
    /// </summary>
    public static class ProtoWebClient
    {
        public static T RequestProto<T>(this WebClient client, string address, object obj)
        {
            byte[] data;
            using (var ms = new MemoryStream())
            {
                Serializer.NonGeneric.Serialize(ms, obj);
                data = ms.ToArray();
            }
            data = client.UploadData(address, data); // data is now the response
            using (var ms = new MemoryStream(data))
            {
                return Serializer.Deserialize<T>(ms);
            }
        }

        public static void CommandProto<T>(this WebClient client, string address, object obj)
        {
            byte[] data;
            using (var ms = new MemoryStream())
            {
                Serializer.NonGeneric.Serialize(ms, obj);
                data = ms.ToArray();
            }
            client.UploadData(address, data); // data is now the response
        }
    }
}