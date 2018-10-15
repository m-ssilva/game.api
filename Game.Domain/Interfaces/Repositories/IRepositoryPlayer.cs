using System;
using Game.Domain.Arguments.Player;

namespace Game.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        Guid AddPlayer(AddPlayerRequest request);
    }
}
