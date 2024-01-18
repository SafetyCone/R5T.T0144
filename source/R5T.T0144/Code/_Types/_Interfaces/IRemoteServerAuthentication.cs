using System;

using R5T.T0142;


namespace R5T.T0144
{
    [DataTypeMarker]
    public interface IRemoteServerAuthentication : IAuthentication
    {
        string HostUrl { get; }
        string PrivateKeyFilePath { get; }
    }
}
