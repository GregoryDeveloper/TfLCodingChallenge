using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TflCodingChallengeLibrary.Model;

namespace TflCodingChallengeLibrary
{
    public class RoadProcessor
    {
        public static async Task<List<ValidRoadModel>> LoadRoad(string road, ApiClient apiClient )
        {
            StringBuilder sb = new StringBuilder();

            string url = sb.Append(Constants.API_URI_BASE_ADDRESS)
              .Append(road)
              .Append(Constants.API_URI_START)
              .Append(apiClient.ApplicationId)
              .Append(Constants.API_URI_END)
              .Append(apiClient.ApplicationKey)
              .ToString();

            using (HttpResponseMessage httpResponse = await apiClient.HttpClient.GetAsync(url))
            {

                if (httpResponse.IsSuccessStatusCode)
                {
                    var jsonString = await httpResponse.Content.ReadAsStringAsync();

                    List<ValidRoadModel> roadModel = JsonConvert.DeserializeObject<List<ValidRoadModel>>(jsonString);

                    return roadModel;
                }
                else if (httpResponse.StatusCode == HttpStatusCode.NotFound)
                {
                    var jsonString = await httpResponse.Content.ReadAsStringAsync();

                    InvalidRoadModel roadModel = JsonConvert.DeserializeObject<InvalidRoadModel>(jsonString);

                    throw new Exception($"{road} {Constants.INVALID_ROAD_ERROR_MESSAGE}");
                }
                else
                {
                    throw new Exception(httpResponse.StatusCode.ToString());
                }
            }

        }
    }
}
