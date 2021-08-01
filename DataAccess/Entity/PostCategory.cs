using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class PostCategory
    {
        public long PostId { get; set; }
        public int CategoryId { get; set; }

        //Relationships
        public Post Post { get; set; }
        public Category Category { get; set; }
    }
}
