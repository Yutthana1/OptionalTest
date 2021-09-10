using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalTest
{
    public class A1
    {
        bool isStop = true;
        public void menu()
        {
            int result;
            do
            {
                Console.Write("\tMenu\n" + "1-line\n" + "2-Rectangle\n" + "3-Triangle\n" + "4-Exit Program\n" + "select menu>>>");
                isStop = int.TryParse(Console.ReadLine(), out result);
                if (result == 1)
                {
                    choice1();
                }
                else if (result == 2)
                {
                    choice2();
                }
                else if (result == 3)
                {
                    choice3();

                }
                else
                {
                    Console.WriteLine("Exit Program....");
                    isStop = false;
                }

            } while (isStop);

        }

        void choice1()
        {
            bool checkInt = true;
            do
            {
                int result;
                Console.Write("Input length of line :> ");
                checkInt = int.TryParse(Console.ReadLine(), out result);
                if (checkInt)
                {
                    for (int i = result - 1; i >= 0; i--)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                    checkInt = false;
                    break;
                }
                else
                {
                    Console.WriteLine("กรุณาใส่ตัวเลขจำนวนเต็ม!!!");
                }
            } while (checkInt != true);
        }
        void choice2()
        {
            bool checklength = true, checknumber = true;

            do
            {
                int resultlength, resultnumber;
                Console.Write("Input length of line :> ");
                checklength = int.TryParse(Console.ReadLine(), out resultlength);
                Console.Write("Input number of line :> ");
                checknumber = int.TryParse(Console.ReadLine(), out resultnumber);
                if (checklength && checknumber)
                {
                    for (int i = 1; i <= resultlength; i++)
                    {
                        for (int j = 1; j <= resultnumber; j++)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    checklength = false;
                    checknumber = false;
                    break;
                }
                else if (checklength && !checknumber)
                {
                    Console.WriteLine("กรุณาใส่ตัวเลข(number)จำนวนเต็ม!!!");
                    continue;
                }
                else if (!checklength && checknumber)
                {
                    Console.WriteLine("กรุณาใส่ตัวเลข(length)จำนวนเต็ม!!!");
                    continue;
                }
                else
                {
                    Console.WriteLine("กรุณาใส่ตัวเลขจำนวนเต็ม&number!!!");
                }
            } while (!checklength && !checknumber);
        }
        void choice3()
        {
            bool checkWidth = true;
            do
            {
                int result;
                Console.Write("Input width of line :> ");
                checkWidth = int.TryParse(Console.ReadLine(), out result);
                if (checkWidth)
                {
                    for (int i = result; i > 0; i--)
                    {
                        for (int j=1;j<i;j++) { 
                         Console.Write("*");
                        }
                        Console.WriteLine(i);
                       
                    }
                    Console.WriteLine();
                    checkWidth = false;
                    break;
                }
                else
                {
                    Console.WriteLine("กรุณาใส่ตัวเลข(Width)จำนวนเต็ม!!!");
                }
            } while (checkWidth != true);
        }

    }
}
