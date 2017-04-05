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
        public List<Row> rows;
        public int gidUsed;
        public ItemManager()
        {
            this.tempItems = new List<Item>();
            this.rows = new List<Row>();
            
            if (!Directory.Exists(this.folder)) { Directory.CreateDirectory(this.folder); }
            if (!File.Exists(this.dataCsv)) 
            {
                File.WriteAllText(this.dataCsv, "gid,iid,name,date,key"); 
            }
            this.loadData();
        }
        public void loadData() {
            this.gidUsed = 0;
            var lines = File.ReadAllLines(this.dataCsv);
            for(int i=1; i<lines.Length; i++)
            {
                Row r = new Row(lines[i]);
                this.rows.Add(r);
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
                Row r = new Row();
                r.gid = id;
                r.iid = i + 1;
                r.name = this.tempItems[i].name;
                r.date = DateTime.Now.ToString("dd/MM/yyyy");
                r.setKeys(keywords);
                this.rows.Add(r);
                File.AppendAllText(this.dataCsv, r.ToString()+"\n");
            }

            this.gidUsed++;
            this.ClearTemp();
        }

    }
}
