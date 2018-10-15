using Game.Domain.Interfaces.Arguments;

namespace Game.Domain.Arguments.Platform
{
    class AddPlatformRequest : IRequest
    {
        public string Name { get; set; }
    }
}
