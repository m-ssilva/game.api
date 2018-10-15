using Game.Domain.Arguments.Player;
using Game.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServicePlayer();

            AuthenticatePlayerRequest request = new AuthenticatePlayerRequest();
            service.Authenticate(request);
        }
    }
}
