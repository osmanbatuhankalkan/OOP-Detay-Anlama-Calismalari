using System;
using System.Runtime.CompilerServices;

namespace Static_Constructor
{
    class Program
    {
         static void Main(string[] args)
         {
            new MyClass();//ilk nesne olduğu için aşşağıdaki myclass sınfınımızda ilk static tetiklenecektir
            new MyClass();//fakat ikinci nesnemizde artık normal constructor ımızdan devam edecektir.

            var datebase1 = Datebase.GetInstance;
            var datebase2 = Datebase.GetInstance;
            var datebase3 = Datebase.GetInstance;
            
            datebase1.ConnectionString = "dslgsags";
         }                
    }

    class MyClass
    {
        public MyClass()//Normal Constructor
        {
           //Bu sınıftan nesne üretilirken ilk tetiklenecek metottur
           System.Console.WriteLine("MyClass Constructor'ı tetiklenmiştir");              
        } 
        static MyClass()//Static Constructor
        {
           //Bu sınıftan ilk nesne üretilirken ilk tetiklenecek metottur
           //Üretilen ilk nesenenin dışında bir daha tetiklenmez !
           System.Console.WriteLine("MyClass STATİC Constructor'ı tetiklenmiştir");
           //Static constructor'ın tetiklenebilmesi için illa ilk nesene üretimi yapılmasına gerek yoktur. İlgili sınıf içiresinde herhangi bir static yapılanmasında tetiklenmesi static cons t. tetiklenmesini sağlayacaktır.
           //Şöyle bir genelleme yapabiliriz static constructor bir kez tetiklendi mi ? işte ozaman bir daha tetiklenmez.(genelleme)             
        }               
    }

    #region  Singleton Design Pattern
    //Bir sınıftan uygulama bazında sade ve sadece tek bir nesene oluşturulmasını istiyorsan kullanabileceğin bir design pattern.j
   
    class Datebase
    {
       Datebase()
       {

       }
       public string ConnectionString{get;set;}
       static Datebase datebase;//Bu referans static bellekte duran bir referans, haliyle bu referansa bir nesne atamamız laızm.
       static public Datebase GetInstance
       {
           get
           {
            return datebase;             
           }              
       }
       static Datebase()//bu nesene atama işlemini static const. yapıyoruz
       {
           datebase = new Datebase();//GetInstance tetiklenince otomatik olarak, bir kereye mahsus bizim bu static const.bir kereye mahsus tetikleneceğini bildiğimden dolayı bunu dedik.              
       }                   
    }
    #endregion                    
}
//* Bir nesnede ilk tetiklenen fonksiyon ?
//* İlk nesne üretilirken static const.
//* ilkinin dışında nesene üretimi normal const.