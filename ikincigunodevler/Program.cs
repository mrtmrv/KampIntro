using System;

namespace ikincigunodevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.category = "Bilgisayar";
            product1.stokNo = 1;
            product1.productName = "Laptop";
            product1.fiyat = 1000;


            Products product2 = new Products();
            product2.category = "Beyaz Eşya";
            product2.stokNo = 2;
            product2.productName = "Buzdolabı";
            product2.fiyat = 2000;

            Products product3 = new Products();
            product3.category = "Spor";
            product3.stokNo = 3;
            product3.productName = "Ayakkabı";
            product3.fiyat = 500;


            Products product4 = new Products();
            product4.category = "Bahçe";
            product4.stokNo = 4;
            product4.productName = "Bahçe Makası";
            product4.fiyat = 60;

            Products[] products = new Products[] { product1, product2, product3, product4 };

            //FOR
            Console.WriteLine("For Döngüsü");

            for (int j = 0; j < products.Length; j++) // Products.Length dediğimizde fonksiyon olan lengthi değil 
                                                      //classta tuttuğun lengthi alıyor. Dizi 
            {
                Console.WriteLine(products[j].category + " -> " + products[j].stokNo + " -> " + 
                    products[j].productName + " -> " + products[j].fiyat + " TL.");           

            }
                     

            //FOREACH
            Console.WriteLine("Foreach Döngüsü");
            foreach (var product in products)
            {
                Console.WriteLine(product.category + " -> " + product.stokNo + " -> " +
                    product.productName + " -> " + product.fiyat + " TL.");
            }

            
            //WHILE
            Console.WriteLine("While Döngüsü");
            int i = 0;
                while (i < products.Length)
                {
               
                Console.WriteLine(products[i].category + " -> " + products[i].stokNo + " -> " +
                    products[i].productName + " -> " + products[i].fiyat + " TL.");
                i++;
            }

        }
        class Products
        {
            public static int Length { get; internal set; }
            public string category { get; set; }
            public int stokNo { get; set; }
            public string productName { get; set; }
            public decimal fiyat { get; set; }
         }
     }
 }

