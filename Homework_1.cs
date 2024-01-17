using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.StepHomeworks
{
    internal class Homework_1
    {
        static void main(string[] args)
        {
            // დავალება 1
            // 1. კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი და გადააკონვერტირეთ double-ში და შეინახეთ ცვლადში სახელად number1.
            // 2. კონსოლის ფანჯრიდან შემოიყვანეთ მეორე ციფრი, ესეც დააკონვერტირეთ double-ში დაშეინახეთ ცვლადში სახელად number2.
            // 3. შექმენით ცვლადი sum  და შეინახეთ მასში number1 მიმატებული number2 ანუ მათი ჯამი და დაბეჭდეთ.

            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double sum = number1 + number2;
            Console.WriteLine(sum);

            // დავალება 2
            // 1. კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი, მეორე ციფრი, დააკონვერტირეთ int-ში.
            // 2. შექმენით ცვლადი result დაშეინახეთ მასში number1 გამრავლებული number2 ანუ მათი ნამრავლი.
            // 3. შეადარეთ result მეტია თუ არა 10ზე და დაბეჭდეთ.

            int numb1 = Convert.ToInt32(Console.ReadLine());
            int numb2 = Convert.ToInt32(Console.ReadLine());
            int result = numb1 * numb2;
            if (result > 10)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            // დავალება 3
            // 1. კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი, მეორე ციფრი და გადააკონვერტირეთ double-ში.
            // 2. შექმენით ცვლადი sum  და შეინახეთ მასში number1 მიმატებული number2 ანუ მათი ჯამი.
            // 3. შექმენით ცვლადი isEven,  bool ტიპის და შეინახეთმასში sum არის კენტი თუ ლუწი.

            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum1 = num1 + num2;
            bool isEven = sum1 % 2 == 0;
            Console.WriteLine(sum1);
            if (isEven)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
