using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TflCodingChallengeLibrary;
using TflCodingChallengeLibrary.Model;
using TflCodingChallengeTest.HttpMessageHandler;

namespace TflCodingChallengeTest
{
    [TestClass]
    public class RoadProcessorTest
    {
        [TestMethod]
        public async Task LoadRoad_ValidRoadTest()
        {
            var fHttpMessageHandler = new Mock<HttpMessageHandlerValidRoad> { CallBase = true };
            var httpClient = new HttpClient(fHttpMessageHandler.Object);

            ApiClient apiClient = new ApiClient(httpClient);

            List<ValidRoadModel> road = await RoadProcessor.LoadRoad("A2", apiClient);

            var expectedRoad = GetValidRoadModel();

            Assert.AreEqual(expectedRoad.displayName, road[0].displayName);
            Assert.AreEqual(expectedRoad.statusSeverity, road[0].statusSeverity);
            Assert.AreEqual(expectedRoad.statusSeverityDescription, road[0].statusSeverityDescription);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception),"A233 is not a valid road")]
        public async Task LoadRoad_InvalidRoadTest()
        {
            var fHttpMessageHandler = new Mock<HttpMessageHandlerInvalidRoad> { CallBase = true };
            var httpClient = new HttpClient(fHttpMessageHandler.Object);

            ApiClient apiClient = new ApiClient(httpClient);

            List<ValidRoadModel> road = await RoadProcessor.LoadRoad("A233", apiClient);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "BadRequest")]
        public async Task LoadRoad_BadRequestTest()
        {
            var fHttpMessageHandler = new Mock<HttpMessageHandlerError> { CallBase = true };
            var httpClient = new HttpClient(fHttpMessageHandler.Object);

            ApiClient apiClient = new ApiClient(httpClient);

            List<ValidRoadModel> road = await RoadProcessor.LoadRoad("A233", apiClient);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "BadRequest")]
        public async Task LoadRoad_BadRequestTest2()
        {
            var fHttpMessageHandler = new Mock<HttpMessageHandlerError> { CallBase = true };
            var httpClient = new HttpClient(fHttpMessageHandler.Object);

            ApiClient apiClient = new ApiClient(httpClient);

            List<ValidRoadModel> road = await RoadProcessor.LoadRoad("A2", apiClient);

        }

        private ValidRoadModel GetValidRoadModel()
        {
            return new ValidRoadModel
            {
                displayName = "A2",
                statusSeverity = "Good",
                statusSeverityDescription = "No Exceptional Delays"
            };
        }
    }
}
