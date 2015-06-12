using VersionOne.SDK.APIClient;

namespace VersionOne.ServiceHost.ServerConnector.Entities
{
    public class Scope : Entity
    {
        internal Scope(Asset asset) : base(asset, null) { }
    }
}