using System;
using Game.Domain.Arguments.Player;
using Game.Domain.Interfaces.Repositories;
using Game.Domain.Interfaces.Services;

namespace Game.Domain.Services
{
    public class ServicePlayer : IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }

        public AddPlayerResponse AddPlayer(AddPlayerRequest request)
        {
            Guid id = _repositoryPlayer.AddPlayer(request);
            return new AddPlayerResponse() { Id = id, Message = "Operação realizada com sucesso!" };

        }

        public AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
