using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalTest
{
    class A2
    {
        int n;
        float data, dataSreach;
        bool isnotErr, isNumber;
        public void SearchAndSumArr()
        {


            Console.Write("how many number :> ");
            isnotErr = int.TryParse(Console.ReadLine(), out n);

            if (isnotErr)
            {
                int i = 0;
                float[] arr = new float[n];
                //Console.WriteLine(arr.Length);
                while (i <= arr.Length)
                {
                    Console.Write("input data[{0}] :> ", i);
                    isNumber = float.TryParse(Console.ReadLine(), out data);
                    if (isNumber)
                    {
                        arr[i] = data;

                        i++;
                        if (i == arr.Length)
                        {

                            Console.Write("input data to search ::> ");
                            bool isSreachNumber = float.TryParse(Console.ReadLine(), out dataSreach);
                            if (isSreachNumber)
                            {
                                float sum = 0.0f;
                                bool isFoundData = false;

                                Console.Write("index\n");
                                for (int j = 0; j < arr.Length; j++)
                                {
                                    Console.Write("{0}\t", j);
                                }
                                Console.WriteLine();
                                for (int k = 0; k < arr.Length; k++)
                                {
                                    Console.Write("{0}\t", arr[k]);

                                    if (arr[k] == dataSreach)
                                    {
                                        sum += arr[k];
                                        isFoundData = true;
                                    }

                                }
                                Console.WriteLine();
                                Console.WriteLine("data\tsum");
                                if (isFoundData)
                                {
                                    Console.WriteLine("{0}\t{1}", dataSreach, sum);
                                }
                                else
                                {
                                    Console.WriteLine("Notfound\t{0}", sum);
                                }

                            }
                            else
                            {
                                Console.WriteLine("ใส่ตัวเลขที่ต้องการค้นหา");

                            }
                            break;

                        };
                    }
                    else
                    {
                        Console.WriteLine("ใส่ตัวเลขจำนวนเต็ม!!!{0}", i);
                        continue;
                    }

                }
            }
            else
            {
                Console.WriteLine("ใส่ตัวเลขจำนวนเต็ม!!!");
            }



        }
    }
}
