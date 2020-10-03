using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Hexarc.AmoCrm.Models;

namespace Hexarc.AmoCrm.Controllers
{
    public sealed class LinksController : ControllerBase
    {
        internal LinksController(AmoApi api) : base(api) { }

        public async Task<Response> Get(String entityType, Int32 id)
        {
            var methodPath = $"{entityType}/{id}/links";
            return await this.PerformRequest<Response>(methodPath, HttpMethod.Get);
        }

        public async Task<Response> Link(String entityType, Int32 id, Link link)
        {
            return await this.Link(entityType, id, new[] { link });
        }

        public async Task<Response> Link(String entityType, Int32 id, IEnumerable<Link> links)
        {
            var methodPath = $"{entityType}/{id}/link";
            return await this.PerformRequest<IEnumerable<Link>, Response>(methodPath, HttpMethod.Post, links);
        }
    }
}
