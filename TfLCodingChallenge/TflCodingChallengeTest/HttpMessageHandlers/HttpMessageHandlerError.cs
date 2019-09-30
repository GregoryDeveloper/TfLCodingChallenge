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
    public class HttpMessageHandlerError : System.Net.Http.HttpMessageHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.BadRequest); 
            return await Task.FromResult(responseMessage);
        }
    }
}
