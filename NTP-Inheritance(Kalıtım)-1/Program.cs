using System;
using System.Runtime.CompilerServices;

namespace Static_Constructor
{
    class Program
    {
         static void Main(string[] args)
         {
            Muhasebeci muhasebeci = new Muhasebeci();
            Mudur mudur = new Mudur();
            Yazilimci yazilimci = new Yazilimci();
            
         }                
    }
    class Personel
    {
       public string Adi {get;set;}
        public string Soyadi {get;set;}
        public string MedeniHal {get;set;}                     
    }
    class Muhasebeci:Personel
    {
          public bool Musavir { get; set;}  //musavirlik sadece muhasebeciye özel
    }
    class Yazilimci:Personel
    {
          public string[] kullandigiDiller{get;set;}
    }
    class Mudur:Personel
    {
 
    }
    //*Normalde böyle tek tek yazmak kod tekrarına sebep olur, verimi düşürür , esnek olmaz vs
    /*
    class Muhasebeci
    {
        public string Adi {get;set;}
        public string Soyadi {get;set;}
        public string MedeniHal {get;set;}                 
    }
    class Yazilimci
    {
        public string Adi {get;set;}
        public string Soyadi {get;set;}
        public string MedeniHal {get;set;}   
    }
    class Mudur
    {
        public string Adi {get;set;}
        public string Soyadi {get;set;}
        public string MedeniHal {get;set;}   
    }
    */                     
}