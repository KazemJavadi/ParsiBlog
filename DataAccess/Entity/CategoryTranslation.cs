using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
        public int OrderValue { get; set; }

        //Relationships
        public Category Category { get; set; }
        public Language Language { get; set; }
    }
}
