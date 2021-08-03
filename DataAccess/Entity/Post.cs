using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    [Table("Post")]
    public class Post
    {
        public long Id { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [MaxLength(200)] /*guid-datetime-rand.extension*/
        public string ImageUrl { get; set; }
        public string Text { get; set; }

        public bool IsPublished { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime LastEditeDate { get; set; }

        public bool IsSoftDeleted { get; set; }

        //Relationships
        public List<PostTag> TagsLink { get; set; }
        public List<Category> CategoriesLink { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
