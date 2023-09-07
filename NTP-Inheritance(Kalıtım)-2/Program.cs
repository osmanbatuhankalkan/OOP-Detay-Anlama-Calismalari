using System;
namespace kalitim2
{
    class Program
    {
         static void Main(string[] args)
         {

         }                
    }
    class BuyukBaba // Baba ve Hala BuyukBaba'nın Derived classdır
    {

    }
    class Baba : BuyukBaba // Burada "BuyukBaba" base class // Anne Baba'nın Derived classdır
    {

    }
    class Hala : BuyukBaba // Burada "BuyukBaba" base class
    {

    }
    class Anne:Baba //*aşşağıda bir sınıf sadece 1 sınıftan kalıtım aldığı için "Anne" yi oğlana tanımlayamıyoruz. Tanımlayabilmek için "Baba" dan kalıtım "Anne" , "Anne"den kalıtım "Ogul" yapıyoruz.
    {

    } 
    class Ogul : Anne // Anne, Baba olamaz // Burada "Anne" base class
    {

    }                     
}