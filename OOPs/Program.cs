using System;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*    Fib prog1 = new Fib();
                prog1.userInput();
                prog1.Calc();
                prog1.Display();*/

            Prime prog2 = new Prime();
            prog2.UserInput();
            prog2.Calc();
            prog2.Display();

            /* Palindrome prog3 = new Palindrome();
             prog3.UserInput();
             prog3.Calc();
             prog3.Display();*/




        }
    }


    class Fib
    {

        private int[] arr;
        private int n;


        public void userInput()
        {

            Console.WriteLine("Enter the nth term ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0) return;
            arr = new int[n];
            arr[1] = 1;

        }

        public void Calc()
        {

            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
        }
        public void Display()
        {


            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }


    class Palindrome
    {

        private int num;
        private bool isPalin;
        public void UserInput()
        {

            Console.WriteLine("Enter a Number to Check Palindrome");
            num = int.Parse(Console.ReadLine());

        }

        public void Calc()
        {

            int temp = num, rev = 0, last;

            while (temp > 0)
            {
                last = temp % 10;
                rev = (rev * 10) + last;
                temp /= 10;
            }
            isPalin = rev == num;
        }

        public void Display()
        {

            Console.WriteLine(isPalin ? "The Number is Palindrome" : "The Number is not Palindrome");

        }



    }


    class Prime
    {

        private int rangeLimit;
        private bool[] isPrime;

        public void UserInput()
        {
            Console.WriteLine("Enter Range Limit");
            rangeLimit = int.Parse(Console.ReadLine());
            if (rangeLimit <= 1) return;
            isPrime = new bool[rangeLimit + 1];

        }

        public void Calc()
        {

            if (isPrime == null) return;

            for (int i = 0; i <= rangeLimit; i++) isPrime[i] = true;

            for (int i = 2; i * i <= rangeLimit; i++)
            {

                if (isPrime[i])
                {

                    for (int j = i * i; j <= rangeLimit; j += i)
                    {
                        isPrime[j] = false;
                    }

                }

            }

        }

        public void Display()
        {
            if (isPrime == null) return;
            for (int i = 2; i <= rangeLimit; i++)
            {
                if (isPrime[i])
                    Console.Write(i + " ");

            }


        }


    }





}
