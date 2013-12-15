using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessSolutions.Models
{
    public class IndexModel
    {
        public List<ThreadModel> Threads { get; set; }
        public bool LoggedIn { get; set; }
        public string Name { get; set; }
    }
}