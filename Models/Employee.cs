﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Interfaces;

namespace WEBAPIDemo.Models
{
    public class Employee : IEntity
    {
        public Guid Id { get ; set ; }
        [Required]
        public string Name { get; set; }
    }
}
