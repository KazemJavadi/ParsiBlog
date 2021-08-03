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
        [MaxLength(500)]
        public string PersianName { get; set; }
        [MaxLength(500)]
        public string EnglishName { get; set; }
        public int? OrderValue { get; set; }

        //Relationships
        public List<PostCategory> PostsLink { get; set; }
    }
}
