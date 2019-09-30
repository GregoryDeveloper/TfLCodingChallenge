using System;
using System.Collections.Generic;
using System.Text;

namespace TflCodingChallengeTest
{
    public static class PathHelper
    {
        public static string ProjectDirectoryPath { get { return GetProjectDirectoryPath(); } }

        private static string GetProjectDirectoryPath()
        {
            string basePath = Environment.CurrentDirectory;
            int index = basePath.IndexOf("\\bin");
            return Environment.CurrentDirectory.Substring(0, index);
        }
    }
}
