using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TflCodingChallengeLibrary;
using TflCodingChallengeLibrary.Model;

namespace TfLCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("The program exited because there was no parameter passed");
                Environment.Exit(-1);
            }

            try
            {
                ApiClient apiClient = new ApiClient(new HttpClient());

                Task.Run(async () =>
                {
                    List<ValidRoadModel>  road = await RoadProcessor.LoadRoad(args[0], apiClient);
                    Console.WriteLine(road[0].ToString());
                }).GetAwaiter().GetResult();

                Environment.Exit(0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }

           
           
        }
    }
}
