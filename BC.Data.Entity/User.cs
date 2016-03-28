﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Data.Entity.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BC.Data.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [MinLength(8)]
        [Required]
        public string Password { get; set; }

        [Required]
        public UserType UserType { get; set; }
    }
}
