using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Review
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public string FullName { get; set; }
        public string Text { get; set; }
        public long ReplyTo { get; set; }

        //Relationships
        public Post Post { get; set; }
    }
}
