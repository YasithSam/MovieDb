﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace movieedb.Models
{
    public class Movie
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
       
        public int Id { get; set; }


    }
}