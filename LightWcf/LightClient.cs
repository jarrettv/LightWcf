// <copyright file="Client.cs" company="Computer Technology Solutions, Inc.">
// Copyright (c) 2011 Computer Technology Solutions, Inc.  ALL RIGHTS RESERVED
// </copyright>
// <author>jvance</author>
// <date>9/2/2011 9:18:42 PM</date>
// <productName></productName>
namespace LightWcf
{
    using System;
    using System.Configuration;
    using System.Net;

    /// <summary>
    /// Summary description for Client
    /// </summary>
    public class LightClient
    {
        public T Request<T, V>(V request)
        {
            T resp = default(T);
            using (var client = new WebClient())
            {
                var address = GetConfiguredAddress(typeof(T));
                resp = client.RequestProto<T>(address, request);
            }
            return resp;
        }

        public void Command<T>(T command)
        {
            using (var client = new WebClient())
            {
                var address = GetConfiguredAddress(typeof(T));
                client.CommandProto<T>(address, command);
            }
        }

        private string GetConfiguredAddress(Type type)
        {
            var name = type.Name + "Url";
            return ConfigurationManager.AppSettings[name];
        }
    }
}
