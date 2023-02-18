using MyWebSite.Entity.DTOS.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Entity.DTOS.Articles
{
    public class ArticleUpdateDto
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryID { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
