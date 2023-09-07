using System;
namespace kalitim2_2
{
    class Program
    {
         static void Main(string[] args)
         {
             new D();            
         }                
    }
    class A
    {
         public A()
         {
            System.Console.WriteLine($"{nameof(A)} Nesnesi Oluşturulmuştur. ");             
         }                
    }
    class B : A
    {
            public B()
            {
              System.Console.WriteLine($"{nameof(B)} Nesnesi Oluşturulmuştur. ");
            }
    }
    class C : B
    {
              public C()
              {
                System.Console.WriteLine($"{nameof(C)} Nesnesi Oluşturulmuştur. ");
              }
    }
    class D : C
    {
               public D()
               {
                 System.Console.WriteLine($"{nameof(D)} Nesnesi Oluşturulmuştur. ");
               }
    } 

}