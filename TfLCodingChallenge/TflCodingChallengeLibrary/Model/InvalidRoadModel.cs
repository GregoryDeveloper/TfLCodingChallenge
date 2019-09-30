using System;
using System.Collections.Generic;
using System.Text;

namespace TflCodingChallengeLibrary.Model
{
    public class InvalidRoadModel
    {
        public string type { get; set; }
        public string timestampUtc { get; set; }
        public string exceptionType { get; set; }
        public int httpStatusCode { get; set; }
        public string httpStatus { get; set; }
        public string relativeUri { get; set; }
        public string message { get; set; }
    }
}
