using System;
using Game.Domain.Enum;
using Game.Domain.ValueObjects;
using prmToolkit.NotificationPattern;

namespace Game.Domain.Entities
{
    public class Player : Notifiable
    {
        public Player()
        {

        }

        public Player(Mail mail, string password)
        {
            Mail = mail;
            Password = password;

            new AddNotifications<Player>(this)
                .IfNotEmail(x => x.Mail.MailAddress, "Informe um e-mail válido")
                .IfNullOrInvalidLength(x=> x.Password, 6, 32, "A senha deve ter entre 6 a 32 dígitos.");
        }

        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Mail Mail { get; set; }
        public string Password { get; set; }
        public EnumPlayerStatus Status { get; set; }
    }
}
