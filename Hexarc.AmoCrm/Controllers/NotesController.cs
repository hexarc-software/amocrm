using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Hexarc.AmoCrm.Models;

namespace Hexarc.AmoCrm.Controllers
{
    public sealed class NotesController : ControllerBase
    {
        internal NotesController(AmoApi api) : base(api) { }

        public async Task<Response> Add(String entityType, IEnumerable<Note> notes)
        {
            var methodPath = $"{entityType}/notes";
            return await this.PerformRequest<IEnumerable<Note>, Response>(methodPath, HttpMethod.Post, notes);
        }

        public async Task<Response> Add(String entityType, Int32 entityId, IEnumerable<Note> notes)
        {
            var methodPath = $"{entityType}/{entityId}/notes";
            return await this.PerformRequest<IEnumerable<Note>, Response>(methodPath, HttpMethod.Post, notes);
        }
    }
}
