using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class ItemManager
    {
        public List<Item> items;
        public ItemManager()
        {
            this.items = new List<Item>();
        }
        public void Clear()
        {
            this.items.Clear();
        }
        public void add(string fullname)
        {
            Item it = new Item(fullname);
            for (int i = 0; i < this.items.Count; i++ )
            {
                if (this.items[i].name == it.name) { throw new Exception("Invalid: item already exists"); }
            }
            this.items.Add(it);
        }
        public void remove(string fullname)
        {
            for (int i = 0; i < this.items.Count; i++ )
            {
                if (this.items[i].fullName == fullname) { this.items.RemoveAt(i); break; }
            }
        }
        /**This will overwrite existing one*/
        public void Save()
        {
            for (int i = 0; i < this.items.Count; i++ )
            {
                File.Copy(this.items[i].fullName, this.items[i].name, true);
            }
        }

    }
}
