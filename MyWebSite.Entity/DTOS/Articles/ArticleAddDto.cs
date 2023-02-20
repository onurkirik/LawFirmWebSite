using MyWebSite.Entity.DTOS.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Entity.DTOS.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public Guid CategoryID { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
