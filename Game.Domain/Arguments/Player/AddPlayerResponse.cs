using Game.Domain.Interfaces.Arguments;
using System;

namespace Game.Domain.Arguments.Player
{
    public class AddPlayerResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
