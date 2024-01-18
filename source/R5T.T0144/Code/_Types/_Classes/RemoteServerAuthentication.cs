using System;

using R5T.T0142;


namespace R5T.T0144
{
    [DataTypeMarker]
    public class RemoteServerAuthentication : IRemoteServerAuthentication
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string HostUrl { get; set; }
        public string PrivateKeyFilePath { get; set; }
    }
}
