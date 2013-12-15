using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessSolutions.Models
{
    public class ThreadModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public CommentSectionModel CommentSection { get; set; }
    }
}