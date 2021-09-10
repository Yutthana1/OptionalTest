using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalTest
{
    class A3
    {
        bool isnotErr;
        int n;
        
        public void max_min_diff()
        {
            Console.Write("how many number :> ");
            isnotErr = int.TryParse(Console.ReadLine(), out n);
            if (isnotErr)
            {
                int i = 0;
                float data,maxnum,minnum;
                float[] arr = new float[n];
                while (i < arr.Length)
                {
                    Console.Write("input data[{0}] :> ", i+1);
                    bool isNumber = float.TryParse(Console.ReadLine(), out data);
                    if (isNumber)
                    {
                        arr[i] = data;
                        //Console.WriteLine("data[{0}] i={1}  ", arr[i],i);
                        i++;
                        if (arr.Length == i) {
                            Console.WriteLine();
                            maxnum = arr[0];
                            minnum = arr[0];
                           
                            for (int j=1;j<arr.Length;j++) {
                                if (maxnum < arr[j]) {
                                    maxnum = arr[j];
                                }
                                if (minnum>arr[j]) {
                                    minnum = arr[j];
                                }
                            }
                            
                            Console.WriteLine("Max is = {0}\nMin is {1}\nDiff is {2}",maxnum,minnum,(maxnum-minnum));
                        }
                    }
                    else
                    {
                        Console.WriteLine("ใส่ตัวเลข!!");
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("ใส่ตัวเลข!!");
            }
        }
    }
}
