using System;

namespace kalitim2
{
    class Program
    {
         static void Main(string[] args)
         {
            D d = new D();
              d.X();           
         }                
    }
    //*Atadan gelen yani A dan gelen kalıtım özelleğini, torunlarda name hidding yaptık yani oradaki ismi ezdik
   
    class A
    {
        public void X()
        {

        }                 
    }
    class B:A
    {
               
    }
    class C:B
    {
                
    }
    class D:C
    {
        public new void X()//eskiden böyle belirtilirmiş şimdi new olarak yazmak zorunda değiliz
        {
                         
        }                 
    }                                 
}