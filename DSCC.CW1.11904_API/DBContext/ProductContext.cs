﻿using DSCC.CW1._11904_API.Model;
using Microsoft.EntityFrameworkCore;

namespace DSCC.CW1._11904_API.DBContext
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}