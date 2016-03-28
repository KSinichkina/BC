﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Data.Entity.Enums;

namespace BC.Data.Entity
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        //assignment (Text on payment) Призначення
        [Required]
        public string Description { get; set; }

        //Long text about project
        [Required]
        public string Info { get; set; }

        [Required]
        public double TotalSum { get; set; }

        public double CurrentSum { get; set; }

        [NotMapped]
        public double NeedSum { get { return TotalSum - CurrentSum; } }

        public string Location { get; set; }

        public string YouTubeLink { get; set; }

        [Required]
        public ProjectStatus ProjectStatus { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

    }
}
