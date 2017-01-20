﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jForumClient.Models
{
    public class TopicModel : PostModel
    {
        [Required, MinLength(3), MaxLength(50)]
        public string Title { get; set; }
        public int Views { get; set; }
        public bool Sticky { get; set; }
        public List<TagModel> Tags { get; set; }
        public PagedModel Posts { get; set; }
        //[Required]
        public int SectionId { get; set; }
    }
}