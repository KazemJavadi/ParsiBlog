﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class LanguageDirectionality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relationships
        public List<Language> Languages { get; set; }
    }
}
