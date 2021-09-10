using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalTest
{
    class A4
    {
        public void villageheadman()
        {
            bool checkloop = true;
            int data, i = 1;
            int idxMax = 0, idxMin = 0;
            int max, min;
          
            List<int> listdata = new List<int>();
            int[] count = new int[9];

            while (checkloop)
            {
                Console.Write("input data[{0}] :> ", i);
                bool isNumber = int.TryParse(Console.ReadLine(), out data);
                if (isNumber && data >= 1 && data <= 9)
                {
                    
                    listdata.Add(data);   
                    count[data - 1] += 1;

                    i++;

                }
                else if (isNumber && data < 0 || data > 9)
                {
                    Console.WriteLine("ไม่มีหมายเลขนี้ {0} ", data);
                    continue;
                }
                else if (isNumber && data == 0)
                {

                    max = count[0];
                    min = count[0];

                    Console.WriteLine("data form villager: ");
                    for (int k = 0; k < listdata.ToArray().Length; k++)
                    {
                        Console.Write(listdata[k] + "\t");

                    }

                    Console.WriteLine();
                    Console.WriteLine("Score of each applycant : ");
                    for (int k = 0; k < count.Length; k++)
                    {


                        if (max < count[k])
                        {
                            max = count[k];
                            idxMax = k;
                        }

                        Console.Write(count[k] + "\t");
                    }
                   
                    for (int k = 0; k < count.Length; k++)
                    {
                        if (max > count[k])
                        {
                            if (min < count[k])
                            {
                                min = count[k];
                                idxMin = k;

                            }
                        }

                    }

                    Console.WriteLine();
                    Console.WriteLine("Head is number {0}\tVote_score is {1}", idxMax + 1, max);
                    Console.WriteLine("Assistant is number {0}\tVote_score is {1}", idxMin + 1, min);
                    // Console.Write(Array.IndexOf(count, max) + "\n");

                    break;
                }
                else
                {
                    Console.WriteLine("กรูณใส่ตัวเลข 1-9!! ");
                    continue;
                }
            }
        }
    }
}
