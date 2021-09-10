using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalTest
{
    class A6
    {
        int i = 0;
        int count_p_U = 0, count_p_S = 0,countStudent_p=0;
        int count_T_A = 0, count_T_B = 0, count_T_C = 0, count_T_F = 0, countStudent_T = 0;
        public void gread(){

            int n;
            Console.Write("how many Student :> ");
            bool isnotErr = int.TryParse(Console.ReadLine(), out n);
            if (isnotErr)
            {
                char type; 
                while (i < n) {
                    
                    Console.Write("Type of exam : ");
                    bool checkType = char.TryParse(Console.ReadLine(),out type);
                    if (checkType)
                    
                    {
                        if (type == 'p')
                        {
                         
                            proposal();
                        }
                        else if (type == 'T')
                        {
                           
                            project();
                        }
                        else {
                            Console.WriteLine("notfound type !!");
                            continue;
                        }
                        
                    }
                    else {
                        Console.WriteLine("กรุณากรอก type ที่ถูกต้อง!!");
                        continue;
                    }
                    
                }
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Proposal {0} students", countStudent_p);
                Console.WriteLine("S = {0}, U = {1}", count_p_S,count_p_U);
                Console.WriteLine("Project {0} students", countStudent_T);
                Console.WriteLine("A = {0}, B = {1}, C = {2}, F = {0}", count_T_A, count_T_B, count_T_C, count_T_F);
                
            }
            else {
                Console.WriteLine("กรุณาใส่ตัวเลข!!");
                }

            }
        void proposal() {
            int score = 0;
            Console.Write("Exam Score : ");
            bool isnotErr = int.TryParse(Console.ReadLine(), out score);
            if (isnotErr) {
                if (score >= 60 && score <= 100)
                {
                    
                    Console.WriteLine("Exam result : S");
                    i++;
                    count_p_S++;
                    countStudent_p++;
                }
                else if (score >= 0 && score < 60)
                {

                    Console.WriteLine("Exam result : U");
                    i++;
                    count_p_U++;
                    countStudent_p++;
                }
                else
                {
                    Console.WriteLine("ใส่จำนวนระหว่าง 0-100");
                }
               
            }
            else {
                Console.WriteLine("ใส่ตัวเลขจำนวนเต็ม!!");
                    
            }
        }
        void project() {
            int score = 0;
            Console.Write("Exam Score : ");
            bool isnotErr = int.TryParse(Console.ReadLine(), out score);
            if (isnotErr)
            {
                if (score >= 80 && score <= 100)
                {
                   
                    Console.WriteLine("Exam result : A");
                    i++;
                    count_T_A++;
                    countStudent_T++;
                }
                else if (score >= 60 && score < 80)
                {
                  
                    Console.WriteLine("Exam result : B");
                    i++;
                    count_T_B++;
                    countStudent_T++;
                }
                else if (score >= 50 && score < 60)
                {
                    
                    Console.WriteLine("Exam result : C");
                    i++;
                    count_T_C++;
                    countStudent_T++;
                }
                else if (score >= 0 && score < 50)
                {
                
                    Console.WriteLine("Exam result : F");
                    i++;
                    count_T_F++;
                    countStudent_T++;
                }
                else
                {
                    Console.WriteLine("ใส่จำนวนระหว่าง 0-100");
                }

            }
            else
            {
                Console.WriteLine("ใส่ตัวเลขจำนวนเต็ม!!");

            }
        }
    }
}
