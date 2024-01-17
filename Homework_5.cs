using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.StepHomeworks
{
    internal class Homework_5
    {
        // ---------------------- ლექცია 6 ----------------------

        // დავალება 1
        public static void power(int a, int b)
        {
            int k = a;
            for(int i = 1; i < b; i++)
            {
                a = a * k;
            }
            Console.WriteLine(a);
        }

        // დავალება 2
        public static bool isPrime(int x)
        {
            bool isPrime = true;
            for(int i = 2; i < x/2 + 1; i++)
            {
                if(x % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        // დავალება 3
        public static void isPalindrome(string str)
        {
            bool isPalindrome = true;

            for(int i = 0; i < str.Length / 2;  i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if(isPalindrome)
                Console.WriteLine($"{str} is a palindrome");
            else
                Console.WriteLine($"{str} is not a palindrome");

        }

        // დავალება 4

        public static string toBinary(int x)
        {
            if (x == 0) return "";
            int remainder = x % 2;
            int y = x / 2;


            return $"{toBinary(y)}{remainder}";
        }


        // დავალება 5
        public static int recursivePower(int num, int power)
        {
            if (power == 0) { return 1; }

            return num * recursivePower(num, power - 1);
        }


        // ---------------------- ლექცია 7 ----------------------

        // დავალება 1
        public class Lector
        {
            private readonly string name;
            private readonly string surname;

            public Lector()
            {

            }

            public Lector(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }

            public string getName() { return name; }
            public string getSurname() { return surname; }

        }

        // დავალება 2

        public class Person
        {
            private readonly string name;
            private readonly string surname;

            public Person()
            {

            }

            public Person(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }

            public string getName() { return name; }
            public string getSurname() { return surname; }
        }

        public class Student : Person
        {
            public Student(string name, string surname) : base(name, surname)
            {
            }
            public void showStudent()
            {
                Console.WriteLine($"Name: {this.getName()}, Surname: {this.getSurname()}");
            }

        }

        // testing
        static void main(string[] args)
        {
            // ლექცია 6, დავალება 6-ის ინფუთი
            //int number = int.Parse(Console.ReadLine());
            //int power = int.Parse(Console.ReadLine()); ;
            //Console.WriteLine($"{number} to the power {power} is {recursivePower(number, power)}");

            // ლექცია 7, დავალება 2-ის ინფუთი
            //Student s1 = new Student("Giorgi", "Otinashvili");
            //Student s2 = new Student("John", "Doe");
            //s1.showStudent();
            //s2.showStudent();

        }


    }
}
