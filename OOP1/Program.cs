using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//101
            product1.Id = 1;
            product1.CategoryId = 2; //mobilyaya karşılık geliyor.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            //Bunları yukardaki gibi oluşturabiliriz.

            //Bunları aynı şekilde aşağıdaki gibi de oluşturabiliriz.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem",UnitPrice=35,};

            //PascalCase   //camelCase
            ProductMenager productMenager  = new ProductMenager();// //örnek oluşturma
           
            productMenager.Add(product1);   // bu aynen şunun gibi bir şey =====>string isim = "Engin";  ProductMenager productMenager; string isim;
            Console.WriteLine(product1.ProductName);
           




     

            //int,double,bool... için değer tip demiştik.Değer tiplerde atamalar tamamen değeri üzerinden olur ve bütün bağlantı kopar.
            //diziler,classlar,absract class,interface...referans tiptir.referans tiplerinde atamalar referansın numarasıyla yapılır.Yani bellekteki adresiyle yapılır. 
            //Biz her zaman bir class ataması yapacağımız zaman unutmamalıyız onu bu şekilde referans tip, yani referans numarası üzerinden atamayı aklımızın bir köşesinde tutuyor olacağız. 

        }
    }
}
