using Game.Domain.Arguments.Platform;

namespace Game.Domain.Interfaces.Services
{
    public interface IServicePlatform
    {
        AddPlatformResponse AddPlatform(AddPlatformRequest request);
    }
}
