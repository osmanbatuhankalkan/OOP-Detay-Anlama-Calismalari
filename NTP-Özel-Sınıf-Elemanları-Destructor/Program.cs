using System;

namespace NTP_Destructor
{
    class Program
    {
       static void Main(string[] args)
       {
         //X();//1. örnek
         //GC.Collect();//Garbage collector devreye sokulmuş oldu. ile erişiriz collectle ilgili verileri topluyor//1. örnek
         System.Console.ReadLine();//topluyor fakat tetiklemek için buna ihtiyaçları var   //1. örnek
         int sayi = 100;//2.örnek
         while(sayi>=1)//2.örnek
         {
             new MyClass2(sayi--);//2.örnek           
         }
         System.Console.WriteLine("*****************");//nerede oluşturuyor nerede imha ediyor bir görelimmm//2.örnek
         GC.Collect();//2.örnek
         System.Console.ReadLine(); //2.örnek 
         //yakaladığı nesneyi imha eder sonkez tetiklenecek          
       }
       static void X()//yukarıda staticte çağırabilmek içinde dışında oluşturduk staticleri sonra zaten derinlemesine işliyip öğreneceğiz//1. örnek
       {
         MyClass m = new MyClass(); //1. örnek               
               
       }                  
    }
    class MyClass //1. örnek
    {
       public MyClass()//1. örnek
       {
          System.Console.WriteLine("Nesne Üretilmiştir..");

       }
       ~MyClass()//1. örnek
       {
           System.Console.WriteLine("Nesne İmha Ediliyor.....");              
       }
                   
    }
    class MyClass2 //2.Örnek
    {
        int no;
        public MyClass2(int no)//2.Örnek
        {
           this.no = no;
           System.Console.WriteLine($"{no}.nesne oluşturulmuştur.");              
        }
        ~MyClass2()//2.Örnek
        {
            System.Console.WriteLine($"{no}.nesene imha edilmiştir.....");             
        }                 
    } 
}