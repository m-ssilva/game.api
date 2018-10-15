using Game.Domain.Interfaces.Arguments;
using Game.Domain.ValueObjects;

namespace Game.Domain.Arguments.Player
{
    public class AddPlayerRequest : IRequest
    {
        public Name Name { get; set; }
        public Mail Mail { get; set; }
        public string Password { get; set; }
    }
}
