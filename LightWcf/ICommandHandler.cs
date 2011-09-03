// <copyright file="IRequestHandler.cs" company="Computer Technology Solutions, Inc.">
// Copyright (c) 2011 Computer Technology Solutions, Inc.  ALL RIGHTS RESERVED
// </copyright>
// <author>jvance</author>
// <date>9/2/2011 9:08:21 PM</date>
// <productName></productName>
namespace LightWcf
{

    /// <summary>
    /// Summary description for IRequestHandler
    /// </summary>
    public interface ICommandHandler<T, V>
    {
        void Handle(T request);
    }
}
