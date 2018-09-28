using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Api.Test.Core
{
    using System.Net.Http;

    using Microsoft.AspNetCore.Mvc.Infrastructure;

    using Newtonsoft.Json.Linq;

    internal static class HttpContentExtensions
    {
        public static async Task<TResult> ReadAsync<TResult>(
            this HttpContent httpContent,
            Func<string, JToken> parser)
        {
            var content = await httpContent.ReadAsStringAsync();
            JToken token = parser(content);
            return token.ToObject<TResult>();
        }
    }
}
