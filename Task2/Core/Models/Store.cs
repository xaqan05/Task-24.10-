using Core.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Store
    {
        Product[] Products;

        public Store()
        {
            Products = new Product[0];
        }

        public void AddProduct(params Product[] newProducts)
        {
            int oldLength = Products.Length;

            Array.Resize(ref Products, Products.Length + newProducts.Length);

            for (int i = 0; i < newProducts.Length; i++)
            {
                Products[oldLength + i] = newProducts[i];
            }

        }

        public Product[] RemoveProduct(int no)
        {

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    Products[i] = null;
                }
            }

            Product[] newProducts = new Product[0];

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] != null)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);

                    newProducts[newProducts.Length - 1] = Products[i];
                }

            }
            return Products = newProducts;
        }

        public Product GetProduct(int no)
        {
            Product foundProduct = null;

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    foundProduct = Products[i];
                    return foundProduct;
                }
            }
            return foundProduct;

        }

        public Product[] FilterProductsByType(TypeEnum type)
        {
            Product[] foundProducts = new Product[0];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Type == type)
                {
                    Array.Resize(ref foundProducts, foundProducts.Length + 1);
                    foundProducts[foundProducts.Length - 1] = Products[i];
                }
            }
            return foundProducts;
        }

        public Product[] FilterProductByName(string name)
        {
            Product[] foundProducts = new Product[0];

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref foundProducts, foundProducts.Length + 1);
                    foundProducts[foundProducts.Length - 1] = Products[i];
                }
            }

            return foundProducts;
        }

        public Product[] GETALL()
        {
            return Products;
        }

    }
}
