using System.Collections.Generic;
using VersionOne.SDK.APIClient;
using VersionOne.ServiceHost.ServerConnector.Entities;
using VersionOne.ServiceHost.ServerConnector.Filters;

namespace VersionOne.ServiceHost.ServerConnector
{
    public interface IQueryBuilder
    {
        IDictionary<string, PropertyValues> ListPropertyValues { get; }
        IEntityFieldTypeResolver TypeResolver { get; }
        IEnumerable<AttributeInfo> AttributesToQuery { get; }

        void Setup(IServices services);
        void AddProperty(string attr, string prefix, bool isList);
        void AddListProperty(string fieldName, string typeToken);
        void AddOptionalProperty(string attr, string prefix);

        IQueryBuilder SortBy(SortBy sort);

        PropertyValues QueryPropertyValues(string propertyName);
        AssetList Query(string typeToken, IFilterTerm filter);
        AssetList Query(string typeToken, IFilter filter);

        string Localize(string text);
    }
}