﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Data.Model
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            Animals = new HashSet<Animal>();
        }

        [Key]
        public int CategoryId { get; set; }
        [StringLength(200)]
        public string Name { get; set; } = null!;

        [InverseProperty("Category")]
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
