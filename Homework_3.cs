using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.StepHomeworks
{
    internal class Homework_3
    {
        static void main(string[] args)
        {

            // დავალება 1
            // დაწერეთ პროგრამა რომელიც კონსოლიდან შემოყვანილი რაიმე n ციფრისთვის დაითვლის ყველა ციფრის ჯამს 1–დან n–მდე.

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of natural numbers from 1 to n is {sum}");

            // დავალება 2
            // გააკეთე კონსოლიდან შემოყვანილი რიცხვის გამრავლების ტაბულის ერთი ბლოკი. (ათის ნამრავლის ჩათვლით)

            int n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n1} * {i}= {n1 * i}");
            }

            // დავალება 3
            // დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ ნახევარპირამიდის ფორმას:
            // *
            // **
            // ***
            // ****

            int n2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n2; i++)
            {
                int k = i;
                while (k > 0)
                {
                    Console.Write("*"); k--;
                }
                Console.WriteLine();
            }

            // დავალება 4
            // დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში შემდეგი სახის პირამიდას:
            //    *
            //   * *
            //  * * *
            // * * * *

            int n3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n3; i++)
            {
                for (int j = 1; j <= n3 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // დავალება 5
            // გამოთვალეთ კონსოლიდან შემოყვანილი რიცხვის ფაქტორიალი.

            int n4 = int.Parse(Console.ReadLine());
            int fact = 1; while (n4 > 0)
            {
                fact = fact * n4;
                n4--;
            }
            Console.WriteLine(fact);


            // დავალება 6
            // დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხული რიცხვის მიხედვით გამოიტანს ციფრებით გამოსახულ პირამიდას.

            int n5 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n5; i++)
            {
                for (int j = 1; j <= n5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
        }
    }
}
