using System;
using System.Net.Http;
using System.Text.Json;
using Hexarc.AmoCrm.Controllers;
using Hexarc.AmoCrm.Models;

namespace Hexarc.AmoCrm
{
    public sealed class AmoApi
    {
        public ContactController Contacts { get; }

        public LeadController Leads { get; }

        public LinkController Links { get; }

        public NoteController Notes { get; }

        public TaskController Tasks { get; }

        public AmoApi(HttpClient httpClient, Uri baseUri, Credentials credentials)
        {
            this.HttpClient = httpClient;
            this.BaseUri = baseUri;
            this.Credentials = credentials;

            this.Contacts = new ContactController(this);
            this.Leads = new LeadController(this);
            this.Links = new LinkController(this);
            this.Notes = new NoteController(this);
            this.Tasks = new TaskController(this);
        }

        internal JsonSerializerOptions JsonSerializerOptions { get; } =
            new() { IgnoreNullValues = true };

        internal HttpClient HttpClient { get; }

        internal Uri BaseUri { get; }

        internal String ApiPath => "api/v4/";

        internal Credentials Credentials { get; }
    }
}
