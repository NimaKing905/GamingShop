﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamingShop.Models
{
    public class TblCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TblAll> TblAlls { get; set; }
        public ICollection<TblProduct> TblProducts { get; set; }
        public ICollection<TblProductRole> TblProductRoles { get; set; }
        public ICollection<TblFactor> TblFactors { get; set; }
    }
}
