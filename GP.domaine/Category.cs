﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product>  products { get; set; }
    }
}
