using System;

namespace LNAR.Demo.Models
{
    public class Class1
    {
    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public float Rating { get; set; }
        public string Desc { get; set; }
        public string[] Categories { get; set; }
    }
}
