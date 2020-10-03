using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Hexarc.AmoCrm.Models;

namespace Hexarc.AmoCrm.Controllers
{
    public abstract class ControllerBase
    {
        private AmoApi Api { get; }

        private HttpClient HttpClient { get => this.Api.HttpClient; }

        private Uri BaseUri { get => this.Api.BaseUri; }

        private String ApiPath { get => this.Api.ApiPath; }

        private Credentials Credentials { get => this.Api.Credentials; }

        private JsonSerializerOptions JsonSerializerOptions { get => this.Api.JsonSerializerOptions; }

        internal ControllerBase(AmoApi api)
        {
            this.Api = api;
        }

        protected internal async Task<TResponse> PerformRequest<TRequest, TResponse>(String methodPath, HttpMethod method, TRequest request)
        {
            var uri = this.ToMethodUri(methodPath);
            var data = JsonSerializer.Serialize(request, this.JsonSerializerOptions);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var message = new HttpRequestMessage
            {
                RequestUri = uri,
                Content = content,
                Method = method
            };
            var response = await this.HttpClient.SendAsync(message);
            var raw = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode) throw new AmoException(response.StatusCode, raw);
            return JsonSerializer.Deserialize<TResponse>(raw, this.JsonSerializerOptions);
        }

        protected internal async Task<TResponse> PerformRequest<TResponse>(String methodPath, HttpMethod method)
        {
            var uri = this.ToMethodUri(methodPath);
            var message = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = method
            };
            var response = await this.HttpClient.SendAsync(message);
            var raw = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode) throw new AmoException(response.StatusCode, raw);
            return JsonSerializer.Deserialize<TResponse>(raw, this.JsonSerializerOptions);
        }

        private Uri ToMethodUri(String methodPath)
        {
            return new Uri(this.BaseUri, $"{ApiPath}{methodPath}{this.Credentials.Query}");
        }
    }
}