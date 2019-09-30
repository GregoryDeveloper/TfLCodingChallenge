using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflCodingChallengeTest.HttpMessageHandler
{
    public class HttpMessageHandlerValidRoad : System.Net.Http.HttpMessageHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string json = "";

            using (var r = new StreamReader($"{PathHelper.ProjectDirectoryPath}/ValidTest.json"))
            {
                json = r.ReadToEnd();
            }
            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json)
            };
            return await Task.FromResult(responseMessage);

        }
    }
}
