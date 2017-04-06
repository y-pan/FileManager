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
        public List<Item> tempItems;
        public string folder = "content"; // folder containing all files
        public string dataCsv = "data.csv"; // csv contains: groupId,itemId,name,keyword1,keyword2,...keywordN
        public List<Record> data;
        public int gidUsed;
        public List<Record> matches;
        public ItemManager()
        {
            this.tempItems = new List<Item>();
            this.data = new List<Record>();
            this.matches = new List<Record>();

            if (!Directory.Exists(this.folder)) { Directory.CreateDirectory(this.folder); }
            if (!File.Exists(this.dataCsv)) 
            {
                File.WriteAllText(this.dataCsv, "gid,iid,name,date,key\n"); 
            }
            this.loadData();
        }
        public void loadData() {
            this.gidUsed = 0;
            var lines = File.ReadAllLines(this.dataCsv);
            for(int i=1; i<lines.Length; i++)
            {
                Record r = new Record(lines[i]);
                this.data.Add(r);
                if (this.gidUsed < r.gid) this.gidUsed = r.gid;
            }
        }
        public void ClearTemp()
        {
            this.tempItems.Clear();            
        }
        public void add(string fullname)
        {
            Item it = new Item(fullname);
            for (int i = 0; i < this.tempItems.Count; i++ )
            {
                if (this.tempItems[i].name == it.name) { throw new Exception("Invalid: item already exists"); }
            }
            this.tempItems.Add(it);
        }
        public void remove(string fullname)
        {
            for (int i = 0; i < this.tempItems.Count; i++ )
            {
                if (this.tempItems[i].fullName == fullname) { this.tempItems.RemoveAt(i); break; }
            }
        }
        /**This will overwrite existing one*/
        public void Save(string keywords)
        {
            int id = this.gidUsed + 1;
            for (int i = 0; i < this.tempItems.Count; i++ )
            {
                File.Copy(this.tempItems[i].fullName, this.folder+"\\"+this.tempItems[i].name, true);
                Record r = new Record();
                r.gid = id;
                r.iid = i + 1;
                r.name = this.tempItems[i].name;
                r.date = DateTime.Now.ToString("dd/MM/yyyy");
                r.setKeys(keywords);
                this.data.Add(r);
                File.AppendAllText(this.dataCsv, r.ToString()+"\n");
            }

            this.gidUsed++;
            this.ClearTemp();
        }

        public void Search(string keys, bool isOr, bool isWhole)
        {
            string[] keyArray = keys.Split(',');
            this.matches.Clear();
            foreach(var d in this.data)
            {
                if (d.hasMatch(keyArray, isOr, isWhole)) { this.matches.Add(d); }
                
            }
        }
    }
}
