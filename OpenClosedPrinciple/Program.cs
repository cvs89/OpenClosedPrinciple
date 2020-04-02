using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public enum Color
    {
        Red, Green, Black
    }

    public enum Size
    {
        S, SM, M, XL, XXL, XXXL
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if(name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            Name = name;
            Color = color;
            Size = size;
        }
        public class ProductFilter
        {
            public static IEnumerable<Product> FilterBySize (IEnumerable<Product> products, Size size)
            {
                foreach (var item in products)
                {
                    yield return item;
                }
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
