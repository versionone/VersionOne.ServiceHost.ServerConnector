using System;

namespace VersionOne.ServiceHost.ServerConnector
{
    public class VersionOneException : Exception
    {
        public VersionOneException(string message) : base(message) { }
    }
}