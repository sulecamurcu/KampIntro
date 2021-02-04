using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductMenager //boyle bir adlandırma görürsen anla ki ürünle iligli OPERASYONLAR var bunun içinde.o operasyonlar ekle sil güncelle filtrele...
    {
       //encapsulation-
       //void-Operasyon işlemlerinden sonr herhangi bir bilgiye ihtiyaç yoksa kullanılıyor.. 
        public void Add(Product product) //101  //ekle operasyonu,ekleme işlemini simule ed.satırda örneği yapıldı.eceğiz.
                                               //metodun nasıl çağrılacağının anlatıldığı yer 
                                              //ProductMenegarin içinden çağıracaksın beni,benim adım Add ve parametre olarak bana product türünde bir şey ver diyorsun.
        {
            Console.WriteLine(product.ProductName+"eklendi.");

        }
        
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName+"güncellendi.");
        }






















      



    }
}
