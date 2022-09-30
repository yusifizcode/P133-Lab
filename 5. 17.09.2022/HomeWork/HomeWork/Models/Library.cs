using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    class Library
    {

        public Product[] Products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Product[] GetProductsByPrice(double minPrice,double maxPrice)
        {
            Product[] newProds = { };

            for (int i = 0; i < Products.Length; i++)
            {
                if(Products[i].Price > minPrice && Products[i].Price < maxPrice)
                {
                    Array.Resize(ref newProds, newProds.Length + 1);
                    newProds[newProds.Length - 1] = Products[i];
                }
            }

            return newProds;
        }

        public Product[] GetProductByName(string name)
        {
            Product[] products = { };

            for (int i = 0; i < Products.Length; i++)
            {
                if(Products[i].Name == name)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = Products[i];
                }
            }

            return products;
        }


    }
}
