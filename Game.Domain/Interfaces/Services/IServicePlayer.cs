using Game.Domain.Arguments.Player;

namespace Game.Domain.Interfaces.Services
{
    public interface IServicePlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        AddPlayerResponse AddPlayer(AddPlayerRequest request);
    }
}
