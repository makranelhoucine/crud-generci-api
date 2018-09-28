using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Xunit;

namespace CRUD.Api.Test
{
    public abstract class EndToEndTest : IClassFixture<WebApplicationFactory<Startup>>, IDisposable
    {
        protected readonly Lazy<HttpClient> Client;

        protected EndToEndTest(WebApplicationFactory<Startup> factory)
        {
            this.Client = new Lazy<HttpClient>(factory.CreateClient);
        }
        
        public void Dispose()
        {
            this.Client?.Value.Dispose();
        }
    }
}
