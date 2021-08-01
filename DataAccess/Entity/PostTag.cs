using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class PostTag
    {
        public long PostId { get; set; }
        public long TagId { get; set; }

        //Relationships
        public Post Post { get; set; }
        public Tag Tag { get; set; }
    }
}
