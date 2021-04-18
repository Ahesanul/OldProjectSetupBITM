﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMVCApp.Models.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(50, MinimumLength =4)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        [NotMapped]
        public List<Student> students { get; set; }
    }
}
