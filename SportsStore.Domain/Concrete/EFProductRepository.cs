﻿using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext conrext = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get
            {
                return conrext.Propducts;
            }
        }
    }
}
