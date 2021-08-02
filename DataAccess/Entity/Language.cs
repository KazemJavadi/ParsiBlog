using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Language
    {
        public int Id { get; set; }
        public int LanguageDirectionalityId { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }
        //public string PersianName { get; set; }
        //public string EnglishName { get; set; }
        [MaxLength(100)]
        public string LocalName { get; set; }
        [MaxLength(100)]
        public string SecondLanguageName { get; set; }
        public bool IsDefault { get; set; }

        //Relationships
        public LanguageDirectionality LanguageDirectionality { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
