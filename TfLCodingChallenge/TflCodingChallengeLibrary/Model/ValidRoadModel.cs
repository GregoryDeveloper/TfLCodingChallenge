using System;
using System.Collections.Generic;
using System.Text;

namespace TflCodingChallengeLibrary.Model
{
    public class ValidRoadModel
    {
        public string type { get; set; }
        public string id { get; set; }
        public string displayName { get; set; }
        public string statusSeverity { get; set; }
        public string statusSeverityDescription { get; set; }
        public string bounds { get; set; }
        public string envelope { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            return sb.Append(Constants.STATUS_HEADER_1).Append(' ').Append(displayName).Append(' ').Append(Constants.STATUS_HEADER_2).Append(Environment.NewLine)
              .Append(Constants.ROAD_STATUS).Append(' ').Append(statusSeverity).Append(Environment.NewLine)
              .Append(Constants.ROAD_DESCRIPTION).Append(' ').Append(statusSeverityDescription).ToString();
        }

    }
}
