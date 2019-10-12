﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Book
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public String Name{ get; set; }

        public String Author { get; set; }
        [DataType(DataType.Currency)]
        [Range(0.01,100.00, ErrorMessage ="Price must be between $0.01 and $100")]
        public double Price { get; set; }
    }
}
