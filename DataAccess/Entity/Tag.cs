using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Tag
    {
        public long Id { get; set; }
        public string EnglishText { get; set; }
        public string PersianText { get; set; }

        //Relationships
        public List<PostTag> PostsLink { get; set; }
    }
}
