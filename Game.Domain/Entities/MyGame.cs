using System;

namespace Game.Domain.Entities
{
    public class MyGame
    {
        public Guid Id { get; set; }
        public GamePlatform GamePlatform { get; set; }
        public bool WishList { get; set; }
        public DateTime WishListDate { get; set; }
    }
}
