using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericEntity<Product> product=new GenericEntity<Product>(new TestDbContext());
            product.Add();
            GenericEntity<ProductDetails> productDetails = new GenericEntity<ProductDetails>(new TestDbContext());
            productDetails.Add();

            List<Product> products=new List<Product>();
             
        }
    }

    public class ProductClass
    {
        private TestDbContext _dbContext;

        public ProductClass(TestDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Add()
        {
            _dbContext.Add(this);
        }
        public void Update() { }
        public void Delete() { }
    }
    public class GenericEntity<T>
    {
        private TestDbContext _dbContext;

        public GenericEntity(TestDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Add() { _dbContext.Add(this); }
        public void Update() { }
        public void Delete() { }
    }
  

    public class TestDbContext : DbContext
    {
        private DbSet<Product> Products { get; set; }
        private DbSet<ProductDetails> ProductDetailses { get; set; }
    }

    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class ProductDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class Sales
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class Ca
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
