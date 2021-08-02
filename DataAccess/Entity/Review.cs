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
        public string Text { get; set; }
        public bool IsGuest { get; set; }

        //Relationships
        public Post Post { get; set; }
        public List<Review> Replays { get; set; }
    }
}
