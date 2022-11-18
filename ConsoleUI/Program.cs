﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
     class Program
    {
            //SOLID'İN Open Closed Principle
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
            foreach (var product in productManager.GetByUnitPrice(60,1000))
            {
                Console.WriteLine(product.ProductName);
            }
        }
        
           
        
    }
}