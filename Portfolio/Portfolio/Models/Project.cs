﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Environment;

namespace Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SkillItems { get; set; }
        public string ImageUrl { get; set; }
        public byte[] Image { get; set; }
        public string ImageContentType { get; set; }
        public IEnumerable<string> SkillItemList
        {
            get { return (SkillItems ?? String.Empty).Split(NewLine); }
        }
    }
}
