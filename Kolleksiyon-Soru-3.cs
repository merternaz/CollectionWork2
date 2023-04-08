using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAlgo
{
    class Koleksion3
    {
        
        static void Main3(string[] args)
        {
          
        }

        public static void Soru3(){

            string[] sesliHarfler={"a","e","ı","i","o","ö","u","ü"};
            string giris="";
            List<string> sesliGirisler=new List<string>();


            try{
                giris=Console.ReadLine();
            }catch(FormatException e){
                Console.WriteLine("hatalı format girdiniz");
            }catch(NullReferenceException e){
                Console.WriteLine("boş deger girdiniz");
            }

           

            for(int i=0;i<giris.Length;i++){

                if(sesliHarfler.Contains(giris[i].ToString())){
                    sesliGirisler.Add(giris[i].ToString());
                }
            }

            sesliGirisler.Sort();
            foreach(var x in sesliGirisler){
                Console.WriteLine("girisler:"+x);
            }
        }
    }
}