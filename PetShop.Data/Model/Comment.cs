﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Data.Model
{
    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Content { get; set; } = null!;
        public int AnimalId { get; set; }

        [ForeignKey("AnimalId")]
        [InverseProperty("Comments")]
        public virtual Animal? Animal { get; set; }
    }
}
