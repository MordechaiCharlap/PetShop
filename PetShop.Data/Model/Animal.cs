﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Data.Model
{
    [Table("Animal")]
    public partial class Animal
    {
        public Animal()
        {
            Comments = new HashSet<Comment>();
        }

        [Key]
        public int AnimalId { get; set; }
        [StringLength(200)]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Birthdate { get; set; }
        public string? PhotoUrl { get; set; }
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Animals")]
        public virtual Category? Category { get; set; }
        [InverseProperty("Animal")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
