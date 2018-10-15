using System;
using Game.Domain.Arguments.Player;
using Game.Domain.Entities;

namespace Game.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        Guid AddPlayer(Player player);
    }
}
