using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TflCodingChallengeLibrary
{
    public class ApiClient
    {
        public HttpClient HttpClient { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationKey { get; set; }

        public ApiClient(HttpClient httpClient)
        {
            ApplicationId = ConfigurationManager.AppSettings[Constants.APPLICATION_ID];
            ApplicationKey = ConfigurationManager.AppSettings[Constants.APPLICATION_KEY];
            HttpClient = httpClient;

            HttpClient.BaseAddress = new Uri(Constants.API_URI_BASE_ADDRESS);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.FORMAT_TYPE));
        }
    }
}
