using System;

using F10Y.T0011;

using R5T.T0142;


namespace R5T.T0144
{
    [DataTypeMarker]
    [InstanceIdentity("1549F133-B8B0-4DE0-8077-BD52B62DEEE2")]
    public class Authentication : IAuthentication
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
