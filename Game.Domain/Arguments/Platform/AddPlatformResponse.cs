using System;
using Game.Domain.Interfaces.Arguments;

namespace Game.Domain.Arguments.Platform
{
    public class AddPlatformResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
