using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Person
    {

        public string Name { get; set; }
        sbyte _age;

        public sbyte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value <= 124)
                {
                    _age = value;
                }
                else
                {
                    throw new InvalidAgeException("Yas 0 ve 124 araliginda olmalidir");
                }
            }
        }
    }
}
