using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        public int OrderValue { get; set; }

        //Relationships
        public List<PostCategory> PostsLink { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
        public Language Language { get; set; }
    }
}
