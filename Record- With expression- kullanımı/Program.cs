using System;
using System.Collections.Generic;
namespace CokBoyutluDiziler_2_BTK
{
    class Program
    {
        static void Main(string[] args)
        {   
           //MyClass m = new MyClass
           //{
        //MyProperty1 = 5,
        //MyProperty2 = 10
           //};
        //*********************************************************************************
        
           //Gün gelip Myproperty2'i 15 yapmak istediğimde
           //m.MyProperty2 = 15; dediğim zaman yapamıyorum çünkü READONLY
           //Neler Yapabiliriz bakalım, CLASS larda ısrarcıysak 2 türlü uzun yoldan çözüm var, 1 adette record lu sırasıyla yapalım

        //MyClass m2 = new MyClass//yeni bir myclass
        //{
                         //MyProperty1 = m.MyProperty1,//bu değişmeyeceği için m.MyProperty1 den alıyoruz
                         //MyProperty2 = 15// değişeceği için 15 değerini veriyoruz
        //};//Tamam bu olmadı değil oldu fakat CLEAN koda uymuyor
        //*********************************************************************************
        //MyClass m2 = m.whith(15);//Bu kullanım yukarıdakine göre daha iyi fakat buda zahmetli oluyor
        //********************************** ARTIK CLASS DEĞİLDE RECORD OLARAK TASARLAYALIM ***********************************************
        MyRecord m = new MyRecord
           {
        MyProperty1 = 5,
        MyProperty2 = 10
           };
           MyRecord m2 = m with{MyProperty2 = 15};//Burada Record ile halletmiş oluyoruz
        
        
        }
    }
    record MyRecord
    {
        public int MyProperty1 {get; init;}
        public int MyProperty2 { get; init; }
       
    }
//*********************************************************************************
         
    class MyClass
    {
         public int MyProperty1 {get; init;}

         public int MyProperty2 { get; init; }
         //*********************************************************************************
         
         //Class üzerinden devam etmeyi düşünüyorsak devam edelim bu nasıl yapılıyormuş bunuda görelim                
         public MyClass white(int property2)//değişecek değeri parametre olarak yazdık
         {
             return new MyClass
             {
                MyProperty1 = this.MyProperty1,//aynı kalsın
                MyProperty2 = property2 // dışarıdan ne geliyorsa onu ver demek       
             };            
         }



    }

}