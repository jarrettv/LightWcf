// <copyright file="Class1.cs" company="Computer Technology Solutions, Inc.">
// Copyright (c) 2011 Computer Technology Solutions, Inc.  ALL RIGHTS RESERVED
// </copyright>
// <author>jvance</author>
// <date>9/2/2011 8:29:40 PM</date>
// <productName></productName>
namespace LightWcf
{
    using System.IO;

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public interface ISerializer
    {
        void Serialize<T>(Stream outputStream, T dto);
        T Deserialize<T>(Stream inputStream);
    }
}
