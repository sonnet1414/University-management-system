﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnversityManagementSystem.Models
{
    public class Designation
    {
        public int DesignationId { get; set; }

         [Display(Name = "Designation")]
        public string DesignationName { get; set; }

    }
}