using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.StepHomeworks
{
    internal class Homework_4
    {
        // დავალება 1
        // შექმენით ერთ განზომილებიანი ორი მასივი.
        // შეავსეთ პირველი მასივი ელემენტებით.
        // გადაიტანეთ პირველი მასივის ელემენტები მეორეში და დაბეჭდეთ მეორე მასივის ელემენტები.

        void Task1_1()
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];

            int num = 0;

            for (int i = 0; i < array1.Length; i++) // filling array1
            {
                array1[i] = num++;
            }

            for (int i = 0; i < array2.Length; i++) // transfering into array2
            {
                array2[i] = array1[i];
                Console.WriteLine(array2[i]);
            }
        }

        // დავალება 2
        // შექმენით ერთ განზომილებიანი ორი მასივი. შეავსეთ ორივე მასივი ელემენტებით.
        // გააერთიანე ერთ მასივში ორივე მასივის ელემენტები. დაბეჭდეთ საბოლოოდ მიღებული მასივი.

        void Task1_2()
        {
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[7] { 6, 7, 8, 9, 10, 11, 12 };

            int[] array3 = new int[array1.Length + array2.Length];

            int index = 0;
            for (int i = 0; i < array3.Length; i++) // using only 1 loop
            {
                if (i < array1.Length)
                {
                    array3[i] = array1[i];
                }
                else
                {
                    array3[i] = array2[++index];
                }

                Console.WriteLine(array3[i]);
            }
        }

        // დავალება 3
        // შექმენით ინტების მასივი და შეავსეთ ელემენტებით. მაგ: 3, 5, -4, 8, 11, 1, -1, 6
        // კონსოლიდან გადმოეცით რაღაც რიცხვი რომელსაც შეინახავთ targetSum ცვლადში.
        // მოძებნეთ მასივში ყველა ის ორი ელემენტი რომლის ჯამიც იქნება targetSum ტოლი და ამ წყვილებისგან შექმენით მასივი.
        // დააბრუნეთ ამ ელემენტების წყვილები კონსოლში.

        void Task1_3()
        {
            int[] arr = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = int.Parse(Console.ReadLine());

            int pairs = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == targetSum)
                    {
                        pairs++;
                    }
                }
            }

            int[,] result = new int[pairs, 2]; // would be easier with lists

            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == targetSum)
                    {
                        result[index, 0] = arr[i];
                        result[index, 1] = arr[j];
                        index++;
                    }
                }
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // -------------------- მოდული 2 --------------------

        // დავალება 1
        // ჩვენ გვაქვს ორგანზომილებიანი მასივი 5x5, რომელიც შევსებულია -100-დან +100-მდე მოცემულ
        // დიაპაზონში არსებული შემთხვევითი რიცხვებით. განსაზღვრეთ მასივის ელემენტების ჯამი მინიმალურ და
        // მაქსიმალურ ელემენტებს შორის.

        void Task2_1()
        {
            int[,] arr = new int[3, 3];
            Random random = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-100, 100);
                }
            }

            // ელემენტებს შორის-ში რა იგულისხმება, ადგილმდებარეობით თუ დიაპაზონში?
            // მგონი დიაპაზონში და მაშინ უბრალოდ ელემენტების ჯამს მინუს (მინ + მაქს) იქნება.

            int min = 99;
            int max = -100;
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                    if (arr[i, j] < min) { min = arr[i, j]; continue; }
                    if (arr[i, j] > max) { max = arr[i, j]; continue; }
                }
            }

            Console.WriteLine(sum - min - max);
        }


        // დავალება 2
        // შექმენით აპლიკაცია, რომელიც მატრიცებზე შეასრულებს ოპერაციებს:
        // მატრიცის რიცხვზე გამრავლება;
        // მატრიცების მიმატება;
        // მატრიცების ნამრავლი;

        public static int[,] multiplyMatrixByScalar(int k, int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = k * matrix[i, j];
                }
            }
            return result;
        }

        public static int[,] addMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] sum = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix2.GetLength(1) != matrix1.GetLength(1))
            {
                throw new ArgumentException("dimensions are different!");
            }
            else
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        sum[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
            }

            return sum;
        }

        public static int[,] productOfMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new ArgumentException("dimensions do not match!");
            }

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int sum = 0;

                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    product[i, j] = sum;
                }
            }

            return product;
        }

        // დავალება 3
        // მომხმარებელს კლავიატურის გამოყენებით შეჰყავს ტექსტი. აპლიკაციამ თითოეული წინადადების
        // პირველი ასო, მაღალი რეგისტრის ასოთი უნდა ჩაანაცვლოს. 

        void Task2_3()
        {
            string[] userInputSentences = Console.ReadLine().Split('.');
            string[] result = new string[userInputSentences.Length];

            for (int i = 0; i < userInputSentences.Length; i++)
            {
                result[i] = $"{char.ToUpper(userInputSentences[i].Trim()[0])}{userInputSentences[i].Trim().Substring(1)}. ";
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }


        // დავალება 4
        // შექმენით აპლიკაცია, რომელიც ტექსტში არასწორ სიტყვებს შეამოწმებს. თუ ტექსტში არასწორი
        // სიტყვა მოიძებნება, ის * სიმბოლოების ერთობლიობით უნდა ჩანაცვლდეს.შედეგების საფუძველზე
        // აუცილებელია მოხდეს მოქმედებების სტატისტიკის ჩვენება.

        void Task2_4()
        {
            Console.WriteLine("Enter text:");
            string inputText = Console.ReadLine();
            Console.WriteLine("Enter incorrect word:");
            string incorrectWord = Console.ReadLine();
            char[] incWordChars = incorrectWord.ToCharArray();

            int occurrencesCount = 0;
            char[] chars = inputText.ToCharArray();

            for (int i = 0; i < chars.Length - incWordChars.Length + 1; i++)
            {
                bool isInside = true;
                int index = 0;
                if (chars[i] == incWordChars[index])
                {
                    index++;
                    for (int j = 1; j < incWordChars.Length; j++)
                    {
                        if (chars[i + j] != incWordChars[index])
                        {
                            isInside = false;
                            break;
                        }
                        index++;
                    }
                }
                else isInside = false;
                if (isInside)
                {
                    for (int j = 0; j < incWordChars.Length; j++)
                    {
                        chars[i + j] = '*';
                    }
                    occurrencesCount++;
                }
            }

            string resultText = new string(chars);
            Console.WriteLine(resultText);
            Console.WriteLine($"Stats: The word '{incorrectWord}' has been replaced {occurrencesCount} times.");
        }

    }
}
