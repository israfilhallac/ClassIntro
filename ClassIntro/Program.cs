using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                ProductId = 1,
                ProductName = "Tv",
                ProductStock = 10
            };

            Product product2 = new Product
            {
                ProductId = 2,
                ProductName = "Telefon",
                ProductStock = 12
            };

            Product product3 = new Product
            {
                ProductId = 3,
                ProductName = "Ps",
                ProductStock = 14
            };


            Product[] products = new Product[] {product,product2,product3 };
            foreach (var prod in products)
            {
           
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("ÜRÜN ID :" +prod.ProductId +":"+"ÜRÜN ADI :"+ prod.ProductName +" "+"ÜRÜN STOK ADEDİ :"+prod.ProductStock);
                


            }

        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int ProductStock  { get; set; }
    }
}
