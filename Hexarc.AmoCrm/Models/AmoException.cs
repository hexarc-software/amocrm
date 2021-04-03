using System;
using System.Net;

namespace Hexarc.AmoCrm.Models
{
    public sealed class AmoException : Exception
    {
        public HttpStatusCode Code { get; }

        public String Details { get; }

        internal AmoException(HttpStatusCode code, String details)
        {
            this.Code = code;
            this.Details = details;
        }
    }
}
