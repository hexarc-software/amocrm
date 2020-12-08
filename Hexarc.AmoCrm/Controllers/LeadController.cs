using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Hexarc.AmoCrm.Models;

namespace Hexarc.AmoCrm.Controllers
{
    public sealed class LeadController : ControllerBase
    {
        internal LeadController(AmoApi api) : base(api) { }

        public async Task<Response> List()
        {
            return await this.PerformRequest<Response>("leads", HttpMethod.Get);
        }

        public async Task<Lead> Get(Int32 id)
        {
            return await this.PerformRequest<Lead>($"leads/{id}", HttpMethod.Get);
        }

        public async Task<Response> Add(IEnumerable<Lead> leads)
        {
            return await this.PerformRequest<IEnumerable<Lead>, Response>("leads", HttpMethod.Post, leads);
        }

        public async Task<Response> Add(Lead lead)
        {
            return await this.Add(new [] { lead });
        }

        public async Task<Lead> Edit(Lead lead)
        {
            var methodPath = $"leads/{lead.Id!.Value.ToString()}";
            return await this.PerformRequest<Lead, Lead>(methodPath, HttpMethod.Patch, lead);
        }

        public async Task<Response> Edit(IEnumerable<Lead> leads)
        {
            return await this.PerformRequest<IEnumerable<Lead>, Response>("leads", HttpMethod.Patch, leads);
        }
    }
}
