using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderValue { get; set; }

        //Relationships
        public List<PostCategory> PostsLink { get; set; }
    }
}
