using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class Lib
    {
        public static string GetName(string path)
        {
            string[] parts = path.Split('\\');
            return parts.Last();

        }
    }
}
