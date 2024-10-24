using Core.Helpers.Exceptions;
using Core.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {
        static int _no = 1;

        public int No;
        public string Name { get; set; }

        double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new PriceMustBeGratherThanZeroException("Qiymet 0 dan asagi ola bilmez");
                }
            }
        }

        public TypeEnum Type { get; set; }

        public Product(string name, double price, TypeEnum type)
        {
            No = _no++;
            Name = name;
            Price = price;
            Type = type;
        }

    }
}
