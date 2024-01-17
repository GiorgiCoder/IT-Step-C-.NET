using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.StepHomeworks
{
    internal class Homework_2
    {
        static void main(string[] args)
        {
            // დავალება 1
            // დაწერეთ C# პროგრამა, რომელიც შეამოწმებს შეყვანილი რიცხვი დადებითია თუ უარყოფითი.

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"{n} is a positive number");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} is a negative number");
            }
            else
            {
                Console.WriteLine($"{n} is zero");
            }

            // დავალება 2
            // დაწერეთ C# Sharp პროგრამა,რომლითაც მომხმარებელი შეიყვანს ამომრჩევლის ასაკს
            // და პროგრამა განსაზღვრავს,აქვს თუ არა მას არჩევნებზე ხმის მიცემის უფლება.

            Console.Write("Enter the age: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 >= 18)
            {
                Console.WriteLine("Congrats! You can vote!");
            }
            else
            {
                Console.WriteLine("Unfortunately you can't vote yet :(");
            }

            // დავალება 3
            // დაწერეთ C# პროგრამა, რომელიც წაიკითხავს მთელი რიცხვი m–ს
            // და n-ს მიანიჭებს 1–ს თუ m 0-ზე მეტია, 0–ს თუ m ტოლია 0 და -1 როცა m 0-ზე ნაკლებია.

            Console.Write("Enter a number: ");
            int m = int.Parse(Console.ReadLine());
            int n2 = 0;

            if (m > 0)
                n2 = 1;
            else if (m == 0)
                n2 = 0;
            else
                n2 = -1;
            Console.WriteLine($"n = {n2}");

            // დავალება 4
            // დაწერეთ C# პროგრამა, რომელიც დაადგენს სამ რიცხვს შორის უდიდესს.

            Console.Write("Enter the first number: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int m3 = int.Parse(Console.ReadLine());

            if (m1 >= m2 && m1 >= m3)
            {
                Console.WriteLine("First number is the biggest");
            }
            else if (m2 >= m1 && m2 >= m3)
            {
                Console.WriteLine("Second number is the biggest");
            }
            else
            {
                Console.WriteLine("Third number is the biggest");
            }

            // დავალება 5
            // დაწერეთ პროგრამა C# -ში, რომელიც წაიკითხავს მთელ რიცხვს, რომელიც შეესაბამება
            // კვირის დღეს (1–ორშ, 2–სამშ, 4–ოთხშ. და ა.შ) და დაბეჭდავს კვირის ამ დღის სახელს.

            Console.Write("Enter the number: ");
            int k = int.Parse(Console.ReadLine());
            // easier with switch statement which we haven't learnt yet
            if (k == 1)
                Console.WriteLine("Monday");
            else if (k == 2)
                Console.WriteLine("Tuesday");
            else if (k == 3)
                Console.WriteLine("Wednesday");
            else if (k == 4)
                Console.WriteLine("Thursday");
            else if (k == 5)
                Console.WriteLine("Friday");
            else if (k == 6)
                Console.WriteLine("Saturday");
            else if (k == 7)
                Console.WriteLine("Sunday");
            else
                Console.WriteLine("Incorrect input!");

            // დავალება 6
            // დაწერეთ C# პროგრამა ორი მოცემული მთელი რიცხვის ჯამის გამოსათვლელად
            // თუ ეს ორი რიცხვი ერთნაირია, მაშინ დააბრუნეთ გასამმაგებული მათი ჯამი.

            Console.Write("Enter the first number: ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int k2 = int.Parse(Console.ReadLine());

            if (k1 == k2)
            {
                Console.WriteLine(3 * (k1 + k2));
            }
            else
            {
                Console.WriteLine(k1 + k2);
            }
        }
    }
}
