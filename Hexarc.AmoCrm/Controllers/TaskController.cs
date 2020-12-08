using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Hexarc.AmoCrm.Models;

namespace Hexarc.AmoCrm.Controllers
{
    public sealed class TaskController : ControllerBase
    {
        internal TaskController(AmoApi api) : base(api) { }

        public async Task<Models.Task> Get(Int32 id)
        {
            return await this.PerformRequest<Models.Task>($"tasks/{id}", HttpMethod.Get);
        }

        public async Task<Response> Add(IEnumerable<Models.Task> tasks)
        {
            return await this.PerformRequest<IEnumerable<Models.Task>, Response>("tasks", HttpMethod.Post, tasks);
        }

        public async Task<Response> Add(Models.Task task)
        {
            return await this.Add(new [] { task });
        }

        public async Task<Response> Edit(IEnumerable<Models.Task> tasks)
        {
            return await this.PerformRequest<IEnumerable<Models.Task>, Response>("tasks", HttpMethod.Patch, tasks);
        }
    }
}
