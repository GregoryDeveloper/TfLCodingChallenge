using System;
using System.Collections.Generic;
using System.Text;

namespace TflCodingChallengeLibrary
{
    public static class Constants
    {
        public const string FORMAT_TYPE = "application/json";
        public const string INVALID_ROAD_ERROR_MESSAGE = "is not a valid road";

        public const string STATUS_HEADER_1 = "The status of the";
        public const string STATUS_HEADER_2 = "is as follows"; 
        public const string ROAD_STATUS = "Road Status is";    
        public const string ROAD_DESCRIPTION = "Road Status Description is";   

        public const string API_URI_BASE_ADDRESS = "https://api.tfl.gov.uk/Road/";
        public const string API_URI_START = "?app_id=";
        public const string API_URI_END = "&app_key=";

        public const string APPLICATION_ID = "applicationId";
        public const string APPLICATION_KEY = "applicationKey";

    }
}
