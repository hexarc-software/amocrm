using System;
using System.Net.Http;
using System.Text.Json;
using Hexarc.AmoCrm.Controllers;
using Hexarc.AmoCrm.Models;

namespace Hexarc.AmoCrm
{
    public sealed class AmoApi
    {
        public ContactsController Contacts { get; }

        public LeadsController Leads { get; }

        public LinksController Links { get; }

        public NotesController Notes { get; }

        public AmoApi(HttpClient httpClient, Uri baseUri, Credentials credentials)
        {
            this.HttpClient = httpClient;
            this.BaseUri = baseUri;
            this.Credentials = credentials;

            this.Contacts = new ContactsController(this);
            this.Leads = new LeadsController(this);
            this.Links = new LinksController(this);
            this.Notes = new NotesController(this);
        }

        internal JsonSerializerOptions JsonSerializerOptions { get; } = 
            new JsonSerializerOptions { IgnoreNullValues = true };

        internal HttpClient HttpClient { get; }

        internal Uri BaseUri { get; }

        internal String ApiPath { get; } = "api/v4/";

        internal Credentials Credentials { get; }
    }
}
