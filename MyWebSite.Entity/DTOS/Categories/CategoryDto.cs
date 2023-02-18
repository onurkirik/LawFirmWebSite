using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Entity.DTOS.Categories
{
    public class CategoryDto
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "Nurselenay ZENGİN";
    }
}
