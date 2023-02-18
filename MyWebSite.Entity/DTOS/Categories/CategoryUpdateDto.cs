using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Entity.DTOS.Categories
{
    public class CategoryUpdateDto
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
