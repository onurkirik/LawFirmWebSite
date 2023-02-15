using MyWebSite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Entity.Entities
{
    public class Image : EntityBase
    {
        public string FileName { get; set; }
        public string FileType { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
