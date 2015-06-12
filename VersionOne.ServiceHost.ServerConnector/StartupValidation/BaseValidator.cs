using Ninject;
using VersionOne.ServiceHost.Core.StartupValidation;

namespace VersionOne.ServiceHost.ServerConnector.StartupValidation
{
    public abstract class BaseValidator : BaseValidationEntity, ISimpleValidator
    {
        [Inject]
        public IVersionOneProcessor V1Processor { get; set; }

        public abstract bool Validate();
    }
}