﻿using Business.Concrete;
using Core.Utilities.Results;
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
            ProductTest();

           // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                     {
                Console.WriteLine(" Ürün adı: " + product.ProductName + " Categori Adı: " + product.CategoryName);
                     }

            }
                else
	               { 
                       Console.WriteLine(result.Message);

                   }
        }
       


    }
}
