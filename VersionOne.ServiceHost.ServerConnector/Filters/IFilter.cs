using VersionOne.SDK.APIClient;

namespace VersionOne.ServiceHost.ServerConnector.Filters
{
    public interface IFilter
    {
        GroupFilterTerm GetFilter(IAssetType type);
    }
}