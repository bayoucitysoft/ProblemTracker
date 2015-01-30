using ProblemTracker.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTracker.Models
{
    public class Entry : BaseObject
    {
        public string Name { get; set; }
        public string Header { get; set; }
        public string Comment { get; set; }
        public DateTime DateCompleted { get; set; }
        public string ParentId { get; set; }
        public string Id { get; set; }
        public string AutoCompleter { get; set; }

        public Entry()
        {
            string guid = Guid.NewGuid().ToString();
            ParentId = guid;
            Id = guid;
        }

        public Entry(string _name, string _header, string _parentId)
        {
            this.Name = _name;
            this.Header = _header;
            this.ParentId = _parentId;
        }

        public Entry(string _name, DateTime _dateCompleted, string _header, string _comment, string parentId)
        {
            // TODO: Complete member initialization
            this.Name = _name;
            this.DateCompleted = _dateCompleted;
            this.Header = _header;
            this.Comment = _comment;
            this.ParentId = parentId;
            this.Id = Guid.NewGuid().ToString();
        }

        public Entry(string _name, DateTime _dateCompleted, string _header, string _comment, string _parentId, string _id)
        {
            this.Name = _name; //prob just need this and ...
            this.DateCompleted = _dateCompleted;
            this.Header = _header;
            this.Comment = _comment;
            this.ParentId = _parentId; // this really... 
            this.Id = _id;
        }

        public Entry(DateTime _dateCompleted, string _header, string _id, string _parentId)
        {
            this.DateCompleted = _dateCompleted;
            this.Id = _id; 
            this.Header = _header;
            this.ParentId = _parentId;
        }


        internal List<Entry> GetHeaders()
        {
            List<Entry> response = new List<Entry>();
            DataTable headers = SQLAccess.GetHeaders("Entry");
            if (headers.Rows.Count > 0)
            {
                foreach (DataRow row in headers.Rows)
                {
                    Entry tmp = new Entry(Convert.ToDateTime(row["DateCompleted"]),
                        Convert.ToString(row["Header"]),
                        Convert.ToString(row["Id"]),
                        Convert.ToString(row["ParentId"]));
                    response.Add(tmp);
                }
            }
            return response;
        }
    }

    public class EntryDisplay
    {
        public string Completed { get; set; }

        public string Header { get; set; }

        public string Id { get; set; }
       
       
        public EntryDisplay(string _dateCompleted, string _header, string _id)
        {
           
            this.Completed = _dateCompleted;
            this.Header = _header;
            this.Id = _id;
        }
     
    }
}
