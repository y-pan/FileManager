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
        /**return format : img, pdf, doc, txt, Empty string for not recognized*/
        public static string getFormat(string path)
        {
            string ext = "";
            if (path.EndsWith(".jpg", true, null)) ext = "img";
            else if (path.EndsWith(".png", true, null)) ext = "img";
            else if (path.EndsWith(".bmp", true, null)) ext = "img";
            else if (path.EndsWith(".gif", true, null)) ext = "img";
            else if (path.EndsWith(".icon", true, null)) ext = "img";
            else if (path.EndsWith(".jpeg", true, null)) ext = "img";
            else if (path.EndsWith(".pdf", true, null)) ext = "pdf";
            else if (path.EndsWith(".doc", true, null)) ext = "doc";
            else if (path.EndsWith(".txt", true, null)) ext = "txt";
            else ext = "";

            return ext;

        }
    }
}
