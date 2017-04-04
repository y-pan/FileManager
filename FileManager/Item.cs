using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class Item
    {
        public string fullName;
        public string name;
        public Item(string fullName)
        {
            this.fullName = fullName;
            this.name = Lib.GetName(this.fullName);
        }

    }
}
