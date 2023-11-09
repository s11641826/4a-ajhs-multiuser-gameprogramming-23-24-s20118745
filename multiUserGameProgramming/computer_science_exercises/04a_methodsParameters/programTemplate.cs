// Alexander Jones, Program Template, v0.5
/* 
You have a significant number of syntax errors in this code. You need to look
at my example as well as test your code using https://onlinegdb.com to find and
remove the syntax errors. 
*/ 
using System;

namespace UpdateForEachProgram
{
    class UpdateForEachProgram
    {



        static void MyMethod()
        {
            Console.WriteLine("I Like Mine with lettuce and tomatoes, Heinz 57, and french fried potatoes.\n");
        }
        // static -- This method belongs to the current class, it is NOT an object
        // void -- This method has no return value.

        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            //sum *= 2;
            //Console.WriteLine(sum);
            return sum *= 2;
        }

        // Mthods with Parameters

        static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("One golden, fluffy pancake coming up1\n");
            }
        }





        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook " + num "humburgers.\n");
        }

        static void AllMyChildren(string child1, string child2, string child3)
        {
            Console.WriteLine("My favorite child is " + child3);
        }

        // METHOD OVERLOADING
        static double FindSum(int x, int y)
        {
            int sumn = x + y;
            Console.WriteLine("Sum: " + sumn);
            return sum;
        }
       
        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes();
            //MakeEggs(10, "sunny side up");
            //MakeBurger(10);
            //AllMyChildren(child3: "Steve"), child2: "Susan", child1: "Chewbacca");
            FindSum(1,5); // TWO INTEGERS
            FindSum(9.5, 2.4); // TWO DOUBLES
            FindSum(5, 2.5); // ONE OF EACH
            }


















static void MakeEggs(int num, string style)
{
    Console.WriteLine("You have ordered" + num + "eggs cooked " + style + ".\n");
}



        static void Main(string[] args
        {

            //MyMethod();
            //DoubleUp();
            MakePancakes();
            MakeEggs(10, "sunny side up");
        }
        
        
        
        )

                return 0;
            
        }


        static void Main(string[] args)
        {
            MyMethod();

        }
    }
}