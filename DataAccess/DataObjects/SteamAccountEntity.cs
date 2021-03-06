using NuciDAL.DataObjects;

namespace SteamGiveawaysBot.Server.DataAccess.DataObjects
{
    public sealed class SteamAccountEntity : EntityBase
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsSteamGiftsSuspended { get; set; }

        public string CreationTimestamp { get; set; }

        public string LastUpdateTimestamp { get; set; }
    }
}
