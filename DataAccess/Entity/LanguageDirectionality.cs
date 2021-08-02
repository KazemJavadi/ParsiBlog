using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class LanguageDirectionality
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public bool IsDefault { get; set; }

        //Relationships
        public List<Language> Languages { get; set; }
    }
}
