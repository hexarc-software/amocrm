using System;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Credentials
    {
        public String UserLogin { get; }

        public String UserHash { get; }

        public String Query { get => $"?USER_LOGIN={this.UserLogin}&USER_HASH={this.UserHash}"; }

        public Credentials(String userLogin, String userHash)
        {
            this.UserLogin = userLogin;
            this.UserHash = userHash;
        }
    }
}
