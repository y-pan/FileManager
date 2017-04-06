using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    /**A Record is data structure for the row of data.csv file containing: groupId,itemId,name,date,keyword1,keyword2,...keywordN.
     Record is to be used in reading history data
     */
    class Record
    {
        public int gid=0;
        public int iid=0;
        public string name;
        //public string fullname;
        public string date;
        public List<string> keys;

        public Record() { keys = new List<string>();}
        /**rowString is a line from data.csv*/
        public Record(string rowString)
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

        public bool hasMatch(string[] passInKeys, bool isOr, bool isWhole)
        {
            if (isOr)
            {               

                if (!isWhole)
                {
                    foreach (var pk in passInKeys)
                    {
                        foreach (var k in this.keys)
                        {
                            if (k.Contains(pk)) return true;
                        }
                    }
                }
                else
                {
                    foreach (var pk in passInKeys)
                    {
                        foreach (var k in this.keys)
                        {
                            if (k==pk) return true;
                        }
                    }
                }
                return false;
            }
            else // record need to match all keywords
            {
                int count = 0;
                if (!isWhole)
                {
                    foreach (var pk in passInKeys)
                    {
                        foreach (var k in this.keys)
                        {
                            if (k.Contains(pk)) { count++; break; }
                        }
                    }
                    if (count == passInKeys.Length) return true;
                    
                }
                else
                {
                    foreach (var pk in passInKeys)
                    {
                        foreach (var k in this.keys)
                        {
                            if (k==pk) { count++; break; }
                        }
                    }
                    if (count == passInKeys.Length) return true;
                }

                return false;
            }

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
