using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Language
    {
        public int Id { get; set; }
        public int LanguageDirectionalityId { get; set; }
        public string Code { get; set; }
        public string PersianName { get; set; }
        public string EnglishName { get; set; }
        public string LocalName { get; set; }
        public int DirectionalityId { get; set; }

        //Relationships
        public List<LanguageDirectionality> LanguageDirectionality { get; set; }
    }
}
