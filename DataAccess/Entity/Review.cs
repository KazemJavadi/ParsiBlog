using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Review
    {
        public long Id { get; set; }
        public long? ReplyToId { get; set; }

        public long PostId { get; set; }

        [MaxLength(200)]
        public string FullName { get; set; }
        [MaxLength(320)]
        public string Email { get;set; }
        [MaxLength(1000)]
        public string Text { get; set; }
        [MaxLength(50)]
        public string IP { get; set; }

        //Relationships
        public Post Post { get; set; }
        
        public Review ReplyTo { get; set; }
        public List<Review> Replies { get; set; }
    }
}
