using System;

using R5T.T0142;


namespace R5T.T0144
{
    /// Uses the interface-get, implementation class-set convention.
    [DataTypeMarker]
    public interface IAuthentication
    {
        /// Uses the lower-case "name" convention.
        string Username { get; }

        /// Uses the lower-case "word" convention.
        string Password { get; }
    }
}
