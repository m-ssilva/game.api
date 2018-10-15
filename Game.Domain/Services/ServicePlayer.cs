using System;
using Game.Domain.Arguments.Player;
using Game.Domain.Entities;
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

        public ServicePlayer()
        {

        }

        public AddPlayerResponse AddPlayer(AddPlayerRequest request)
        {
            Player player = new Player();
            player.Mail = request.Mail;
            player.Name = request.Name;
            player.Status = Enum.EnumPlayerStatus.Pendente;

            Guid id = _repositoryPlayer.AddPlayer(player);

            player.Status = Enum.EnumPlayerStatus.Ativo;

            return new AddPlayerResponse() { Id = id, Message = "Operação realizada com sucesso!" };
        }

        public AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request)
        {
            if (request == null)
            {
                throw new Exception("Autenticar Jogador Request é obrigatório");
            }

            var response = _repositoryPlayer.Authenticate(request);

            return response;
        }
    }
}
