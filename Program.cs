using System;

namespace ZadaniaDljaKollegi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kollega,Privet!");
            //первый цикл - напечатать числа от 1 до 10
            int[] myarray = new int[11];
            for (int i = 1; i < myarray.Length; i++)
            {
                Console.WriteLine(i);//ПЕРВЫЙ СПОСОБ
            }

            Console.ReadLine();
            for (int i = 1; i < myarray.Length; i++)
            { 
                if (i > 0 && i <= 10)
                {
                    Console.WriteLine(i);//ВТОРОЙ СПОСОБ
                }
                else
                {
                    throw IndexOutOfRangeException();
                }

            }
        }

        private static Exception IndexOutOfRangeException()
        {
            throw new NotImplementedException();
        }
    }
}
/*
  Skype: 29 марта 2019
ok next assignment. 
print numbers from 10 to 20. you can modify the loop I wrote or white a new one. 
assignment 
3. print numbers from 10 to 20 in step of 2. (10,12,14,16...)
assignment 
4. print numbers from 10 to 1 in descending order (10,9,8,7...)
assignment 
5. create an array of 10 elements of type integer. fill the array with numbers from 0 to 9. print all elements of the array (2 loops)
don't spend more than 15 minutes on any of these assignments. if you can't do it in 15 minutes, message me

Function that takes a string and returns string comma string
ha -> ha,ha
boo -> boo,boo
3. Function that takes a string and returns string comma length of string
ha -> ha,2
boo-> boo,3
4. Function that takes a string and returns the string repeated 3 times
ha -> hahaha
boo -> boobooboo
5. Function that takes a string and returns that string repeated 10 times
a -> aaaaaaaaa
6. Function that takes a string and an integer and returns that string repeated that many times
F6("ha",2) -> "haha"
F6("boo",3) -> "boobooboo"

7. Function that takes an integer and returns integer that is greater than the input and is divisible by 3 (input 1 -> output 3, 2->3, 3->6, 100->102)
 */


