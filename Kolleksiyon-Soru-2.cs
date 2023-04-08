using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAlgo
{
    class Koleksion2
    {
        
        static void Main2(string[] args)
        {
          
        }

        public static void Soru2(){
            Console.WriteLine(" *************Soru 2 Scripti************");
            int[] sayilar=new int[20];
            int a=0,counter=0;
            while(a++<5){
                bas:
                try{
                    int x=Convert.ToInt32(Console.ReadLine());
                    sayilar[counter]=x;
                    counter++;
                }catch(FormatException e){
                    Console.WriteLine(e.ToString());
                    counter--;
                    goto bas;
                }
            }
           
            int[] yeni=SıralaBuyukKucuk(sayilar,counter);
            int minSum=0,maxSum=0;
            
          
             Console.WriteLine(" ************");
            
            for(int i=0;i<3;i++){
                maxSum+=yeni[i];
                minSum+=yeni[counter-1-i];
            }
            
            
            

            Console.WriteLine("Minimum 3lu toplam:"+minSum+"  ortalama:"+minSum/3);
            Console.WriteLine("Max 3lu toplam:"+maxSum+"  ortalama:"+maxSum/3);
        }

        public static int[] SıralaBuyukKucuk(int[] dizi,int count){
            int[] yeniDizi=dizi;
            int baslangic=dizi[0];
            int buyuk=0;
            int minDeger=dizi.Min();
            for(int i=0;i<count;i++){
                for(int y=0;y<count;y++){
                    
                        if(dizi[i]>dizi[y])
                            {
                            buyuk=dizi[i];
                            dizi[i]=dizi[y];
                            dizi[y]=buyuk;

                            }
                    

                }
                
                
            }
            /*
            
            for(int i=0;i<count;i++){
                for(int y=0;y<count;y++){
                    if(i>0)
                    {
                        if(dizi[i-1]>dizi[i])
                            {
                            buyuk=dizi[i-1];
                            dizi[i-1]=dizi[i];
                            dizi[i]=buyuk;

                            }
                    }

                }
                
                
            }*/
            //3,2,6,9,1
            //2,3,6,1,9
            //
            return dizi;

        }
    }
}