using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Hexarc.AmoCrm.Models;

namespace Hexarc.AmoCrm.Controllers
{
    public sealed class ContactController : ControllerBase
    {
        internal ContactController(AmoApi api) : base(api) { }

        public async Task<Response> List()
        {
            return await this.PerformRequest<Response>("contacts", HttpMethod.Get);
        }

        public async Task<Contact> Get(Int32 id)
        {
            return await this.PerformRequest<Contact>($"contacts/{id}", HttpMethod.Get);
        }

        public async Task<Response> Add(IEnumerable<Contact> contacts)
        {
            return await this.PerformRequest<IEnumerable<Contact>, Response>("contacts", HttpMethod.Post, contacts);
        }

        public async Task<Response> Add(Contact contact)
        {
            return await this.Add(new[] { contact });
        }

        public async Task<Contact> Edit(Contact contact)
        {
            var methodPath = $"contacts/{contact.Id!.Value.ToString()}";
            return await this.PerformRequest<Contact, Contact>(methodPath, HttpMethod.Patch, contact);
        }

        public async Task<Response> Edit(IEnumerable<Contact> contacts)
        {
            return await this.PerformRequest<IEnumerable<Contact>, Response>("contacts", HttpMethod.Patch, contacts);
        }
    }
}
