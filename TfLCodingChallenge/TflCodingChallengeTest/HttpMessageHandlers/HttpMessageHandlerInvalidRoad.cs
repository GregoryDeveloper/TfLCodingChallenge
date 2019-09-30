using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflCodingChallengeTest.HttpMessageHandler
{
    public class HttpMessageHandlerInvalidRoad : System.Net.Http.HttpMessageHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string json = "";

            using (var r = new StreamReader($"{PathHelper.ProjectDirectoryPath}/InvalidTest.json"))
            {
                json = r.ReadToEnd();
            }
            var responseMessage = new HttpResponseMessage(HttpStatusCode.NotFound)
            {
                Content = new StringContent(json)
            };
            return await Task.FromResult(responseMessage);
        }
    }
}
