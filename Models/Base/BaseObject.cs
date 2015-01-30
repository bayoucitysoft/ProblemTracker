using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProblemTracker.Models
{
    public class BaseObject 
    {
        private bool canUpdate;
        public bool CanUpdate
        {
            get { return canUpdate; }
            set { canUpdate = true; }
        }
    }
}
