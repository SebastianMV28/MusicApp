using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Utils
{
    public class FileUtils
    {
        public static string GetInfoFile(string dataFile)
        {
            return File.ReadAllText(dataFile);
        }

        public static void WriteFile(string dataFile, string json)
        {
            File.WriteAllText(dataFile, json);
        }
    }
}
