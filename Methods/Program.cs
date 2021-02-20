using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Masa";
            product1.Price = 55;
            product1.Description = "El Yapımı Masa";

            Product product2 = new Product();
            product2.Name = "Sehpa";
            product2.Price = 35;
            product2.Description = "Plastik Sehpa";

            Product[] products = new Product[] {product1,product2 };
            foreach ( Product product in products)
            {
                Console.WriteLine("Ürün İsmi :"+product.Name);
                Console.WriteLine("Ürün Fiyatı :" + product.Price);
                Console.WriteLine("Ürün Açıklaması :" + product.Description);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("---------Methods-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
        }
    }
}
