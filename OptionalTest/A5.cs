using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalTest
{
    class A5
    {
        public void sumOfdiff()
        {
            int n;
            Console.Write("how many number :> ");
            bool isnotErr = int.TryParse(Console.ReadLine(), out n);
            if (isnotErr)
            {
                int i = 0, data1=0, data2=0;
                int[] arr1 = new int[n];
                int[] arr2 = new int[n];
                while (i < arr1.Length)
                {
                    Console.Write("Input data1[{0}] :> ", i + 1);
                    bool isnotErrData1 = int.TryParse(Console.ReadLine(), out data1);
                    if (isnotErrData1)
                    {
                        arr1[i] = data1;
                        //Console.WriteLine("data1[{0}]={1}",i,arr1[i]);
                        i++;
                        if (i == arr1.Length)
                        {
                            fnArr2(arr2,data2);
                            difAndPow(arr1,arr2);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Please input number !!");
                    }

                }
            }
            else { Console.WriteLine("กรูณใส่ตัวเลข"); }
        }
        void fnArr2(int[] arr2,int data2)
        {
            Console.WriteLine("--------------------------");
            int i = 0;
            while (i < arr2.Length)
            {
                Console.Write("Input data2[{0}] :> ", i + 1);
                bool isnotErrData1 = int.TryParse(Console.ReadLine(), out data2);
                if (isnotErrData1)
                {
                    arr2[i] = data2;
                    //Console.WriteLine("data1[{0}]={1}",i,arr2[i]);
                    i++;     
                }
                else
                {
                    Console.WriteLine("Please input number !!");
                    continue;
                }

            }
        }
        void difAndPow (int[] arr1,int[] arr2) {
            double powArrTwo=0.0,sumArrTwo=0.0;
            Console.WriteLine("--------------------------");
            for (int i=0;i<arr1.Length;i++) {
                powArrTwo =  Math.Pow(arr1[i] - arr2[i],2);
                sumArrTwo += powArrTwo;
                Console.WriteLine("data1[{0}] - data[{1}] = {2}",arr1[i],arr2[i], powArrTwo);

            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sum of diff-Square is "+ sumArrTwo);

        }
    }
}
