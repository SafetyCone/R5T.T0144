using System;

using R5T.T0142;


namespace R5T.T0144
{
    [DataTypeMarker]
    public class Authentication : IAuthentication
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
