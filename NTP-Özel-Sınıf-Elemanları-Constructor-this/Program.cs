using System;

namespace Constructor_this
{
          //* Öncekikle this tanımı kısaca yapalım bir constructordan diğerine atlamayı sağlıyor. "(işaret ettiren):this(işaret edilen)" aklımızda kalıcı olsun diye böyle bir förmül yarattığımızı var sayalım. constructorda parametreden sonra gelen this yani şaret edilenin constructor u önceliklidir. Bu bir zincir ise zincirin sonuna ulaşıldığında, ilk önce o sondakinin constructoru patlar sonrasında dizi halinde sonra geriye doğru yani ilk construtora doğru bir yolculukla constructorlar ve içerisindeki değerler işelem alınmaya başlar.              
     class Program
     {
        static void Main(string[] args)
        {
           new MyClass(5,10);//Burada biz aslında OverLoading halinde yığın haline getirdiğimiz MyClass sınıfı içerisinden 3.Constructoru çalıştırdık. O Çalışınca this operatörü a yi işaret etti yani 2.Constructor. O da çalışınca kendi içersindeki this in işaret ettiği 1. Constructora gitti ve o kendi sınıfı içerisinden sırasıyla dönmeye başladı.
           //* Böyle zincir bir yapı kurmuşsan her zaman ilk yazdığın son okunur. Sondan ilkde doğru kademeli gider               
        }
     }
     class MyClass
     {
           //public int x;              
           public MyClass()
           {
                System.Console.WriteLine("1.Constructor");         
           }
           public MyClass(int a) : this()
           {
                System.Console.WriteLine($"2.Constructor : a = {a}");         
           }
           public MyClass(int a, int b) : this(a) //* Burada a değerini manuelde verebilirdik this(5) gibi istersekte this(a) olarakta verebiliriz. Fakat önemli nokta burada class içinde değişken yaratip bunu this içinde kullanmaya çalışmak bu olmaz hata alırız yukarıdaki x i kullanamayız.
           {
                System.Console.WriteLine($"3.Constructor : a = {a} | b = {b}");         
           }              
     }                    
}