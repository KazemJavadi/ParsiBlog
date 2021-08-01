using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Text { get; set; }
        public int OrderValue { get; set; }

        //Relationships
        public Category Category { get; set; }
    }
}
