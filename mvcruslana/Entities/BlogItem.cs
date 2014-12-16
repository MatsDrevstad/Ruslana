using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcRuslana.Entities
{
    public class BlogItem
    {
        public int Id { get; set; }
        public string BlogHeader { get; set; }
        public string BlogText { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BlogCreated { get; set; }
        public List<BlogPhoto> Photos { get; set; }
    }
}