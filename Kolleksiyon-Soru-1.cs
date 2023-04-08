using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAlgo
{
    class Koleksion1
    {
        
        static void Main(string[] args)
        {
           
        
            Soru1();
            Koleksion2.Soru2();
            Koleksion3.Soru3();
        }

        public static void Soru1(){

            ArrayList asalList=new ArrayList();
            ArrayList asalOlmayanList=new ArrayList();
            int a=20;
            while(a-->0){
                bas:
                try{
                    int x=Convert.ToInt32(Console.ReadLine());
                     if(x>0)
                     {
                        if(Asal(x))
                        {
                        asalList.Add(x);
                        }else
                        {
                        asalOlmayanList.Add(x);
                        }
                    }else{
                        Console.WriteLine("0 girilmez:");
                        goto bas;
                    }
                }catch(FormatException e){
                    Console.WriteLine("Nümeric değil:");
                    goto bas;
                }
            }
            asalList.Sort();
            asalOlmayanList.Sort();
            int asalSum=0,notAsalSum=0;
            foreach(var asal in asalList){
                Console.WriteLine("Asal:"+asal);
                asalSum+=Convert.ToInt32(asal);
            }
            foreach(var notAsal in asalOlmayanList){
                Console.WriteLine("Asal olmayan:"+notAsal);
                notAsalSum+=Convert.ToInt32(notAsal);
            }
           
            Console.WriteLine("Asal adedi:"+asalList.Count+"  "+"Asal Ortalama:"+(asalSum/asalList.Count));
            Console.WriteLine("Asal Olmayan adedi:"+asalOlmayanList.Count+"  "+"Asal Ortalama:"+(notAsalSum/asalOlmayanList.Count));
        }


        public static bool Asal(int x){

            bool asal=true;
            
            
            for(int i=2;i<x;i++){
                if(x%i==0){
                    asal=false;
                }
            }

            return asal;

        }
    }
}