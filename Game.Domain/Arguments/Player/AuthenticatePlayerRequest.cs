using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Arguments.Player
{
    public class AuthenticatePlayerRequest
    {
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
