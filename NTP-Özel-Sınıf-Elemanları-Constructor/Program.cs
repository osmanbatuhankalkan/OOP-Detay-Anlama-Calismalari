using System;

namespace oop_sinif
{
     class Program
     {
        static void Main(string[] args)
        {
           new MyClass();
           new MyClass();  
           new MyClass();  
           new MyClass();  
           new MyClass();  
           new MyClass();
           //Bir sürü Myclass nesnesi oluşturduk her birinin kendine ait constructorı var her biri ayrı olarak tetikleneceği için ekrana çıktılarımızı verecektir, verilen bu değer ilk tetiklenen constructor sayesindedir. aşşağıdaki classımızdaki constructor içinde fieldlarımız olsaydı onların bir değeri olsaydi her bir nesenesnin üretimden sonra o fieldlardaki verilen değerlerle üretildiğini görecektik. 
           //Bir nesneyi oluştururken ilk tetiklenen fonksiyona biz constructor fonksiyon diyoruz.
           //MyClass m = new MyClass();//üretilecek olan nesenenin referansı neyse bu tür bir referans yerine 
           MyClass m = new();//c#9.0 ile beraber referansa karşılık nesneyi üretebiliyorduk Referansın türünden alır, construvtor tetiklenir.      
        }              
     }
     class MyClass
     {
           public MyClass()
           {
              System.Console.WriteLine("BİR ADET MYCLASS NESNESİ OLUŞTURULMUŞTUR.");           
           }
           public void X()
           {

           }              
     }
}
//Normal bir member sınıf ismiyle aynı olamaz.
//Constructor olabilmesi için bazı şartları sağlaması lazım: 
//1) Metot adı , Sınıf adıyla aynı olmalıdır.(özel sınıf elemanları dışında hiçbir member sınıf adıyla aynı olamaz) 
//2) Geri dönüş değeri olmaz.(void bile olmayacak) 
//3) Erişim belirleyicisi public olmalıdır.(private olduğu değerleri ayı işleyeceğiz)

//Genellikle bu sınıftan üretilecek olan, nesenelerin ilk değerlerini , fieldların ilk değerlerini, yapılması gereken ilk işlemleri, aksiyonları bu sınıftan ilk nesene üretilmesi gerekirken yapılması gereken şey ne ise ilk iş ne ise onları burada yapabilirsin.