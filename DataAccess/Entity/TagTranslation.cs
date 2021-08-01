using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class TagTranslation
    {
        public long Id { get; set; }
        public long TagId { get; set; }
        public string Text { get; set; }
        public int OrderValue { get; set; }

        //Relationships
        public Tag Tag { get; set; }
    }
}
