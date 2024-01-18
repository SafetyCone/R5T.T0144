using System;

using R5T.T0142;


namespace R5T.T0144
{
    [DataTypeMarker]
    public interface IHasAuthentication
    {
        Authentication Authentication { get; }
    }
}
