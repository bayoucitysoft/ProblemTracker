using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProblemTracker.Models.LiquibaseModels
{
    public class ChangeLog
    {
        public List<ChangeSet> ChangeSets { get; set; }

        public ChangeLog()
        {
            this.ChangeSets = new List<ChangeSet>();
        }
    }
    public class ChangeSet
    {
        public string Author { get; set; }
        public string Id { get; set; }
        public List<string> Sql { get; set; }

        public ChangeSet()
        {
            this.Sql = new List<string>();
        }

        public ChangeSet(string author, string id)
        {
            this.Sql = new List<string>();
            this.Author = author;
            this.Id = id;
        }
    }

}