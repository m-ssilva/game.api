using System;
using Game.Domain.Enum;
using Game.Domain.ValueObjects;

namespace Game.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Mail Mail { get; set; }
        public string Password { get; set; }
        public EnumPlayerStatus Status { get; set; }
    }
}
