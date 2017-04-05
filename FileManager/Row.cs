using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    /**A Row is data structure for the row of data.csv file containing: groupId,itemId,name,date,keyword1,keyword2,...keywordN.
     Row is to be used in reading history data
     */
    class Row
    {
        public int gid=0;
        public int iid=0;
        public string name;
        public string fullname;
        public string date;
        public List<string> keys;

        public Row() { keys = new List<string>();}
        /**rowString is a line from data.csv*/
        public Row(string rowString)
        {
            keys = new List<string>();
            if (rowString.Length > 0)
            {
                string[] parts = rowString.Split(',');
                if (parts.Length >= 5)
                {
                    int.TryParse(parts[0].ToString(), out this.gid);
                    int.TryParse(parts[1].ToString(), out this.iid);
                    this.name = parts[2];
                    this.date = parts[3];
                    for (int i = 4; i < parts.Length; i++)
                    {
                        keys.Add(parts[i]);
                    }
                }
            }
            
        }
        /**keyString is keywords seperated by "," */
        public void setKeys(string keyString)
        {
            this.keys.Clear();
            this.keys = keyString.Split(',').ToList<string>();
        }
        public override string ToString()
        {
            string ks="";
            for(int i=0; i<keys.Count; i++)
            {
                if (i < keys.Count - 1) { ks += keys[i] + ","; }
                else { ks += keys[i]; }
            }
            return this.gid+","+this.iid+","+this.name+","+this.date+","+ks;
        }
    }
}
