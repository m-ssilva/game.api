using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Interfaces.Services
{
    public interface IServicePlataform
    {
        AddPlatformResponse AddPlatform(AddPlatformRequest request);
    }
}
