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
           //***************************************************
           new MyClass2(10);
           new MyClass2(5);
           MyClass2 m2 = new(55);     
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
     class MyClass2
     {
      public MyClass2(int a)//burada içeride parametre tanımladığımızdan itibaren yukarıda yaratılan neslereinde parametre içleri doldurulması gerekmektedir.yoksa hata alırız. buradaki parametre ne türde yaratılmışsa o
      {
         System.Console.WriteLine("Parametre alan Constructor"+ " "+ a);
      }
     }
     //********************** Constructor Overloading *****************************
     //*işleyeceğiz
     //Genellikle biz parametreyi dış dünyada alır, aldığımız parametre üzerinden nesneyi oluştururken belirli ilk değerleri o dış dünyadan gelen değerler üzerinden veririz.
     //Overloading belirli durumlara göre farklı varyasyonlara göre nesne oluşum sürecini destekleyici niteliktedir.
     class MyClass3
     {
      public MyClass3()
      {

      }
      public MyClass3(int a)
      {

      }
      public MyClass3(string a)
      {

      }
      public MyClass3(string a, int b)
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
