using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.StepHomeworks
{
    internal class Homework_6
    {
        // მოდული 3, ნაწილი 1

        // დავალება 1
        // I will write without converting to string since I did it in previous homework.
        public static bool isPalindrome(int number)
        {
            int n1 = number;
            int n2 = 0;

            while (number > 0)
            {
                n2 = n2 * 10 + number % 10;
                number = number / 10;
            }

            return n1 == n2;
        }


        // დავალება 2
        public class WebPage
        {
            public string Name { get; set; } // As I found, this syntax also creates a private field Name, so we don't need to write it.
            public string Url { get; set; }
            public string Description { get; set; }
            public string IPAddress { get; set; }

            public WebPage(string name, string url, string desc, string ipaddress)
            {
                Name = name;
                Url = url;
                Description = desc;
                IPAddress = ipaddress;
            }

            public void showWebPage()
            {
                Console.WriteLine($"Name: {Name}, Description: {Description}");
            }

            public (int, int, int, int) getIPAddress()
            {
                int[] s = IPAddress.Split('.').Select(str => int.Parse(str)).ToArray();
                return (s[0], s[1], s[2], s[3]);
            }

            public void goToWebPage()
            {
                Process.Start("chrome.exe", $"https://www.{Url}");
            }

        }


        // დავალება 3
        public class Market
        {
            public string Name { get; set; }
            public List<string> Address { get; set; } // market may have many addresses
            public string Description { get; set; }
            public string phoneNumber { get; set; }
            public string Email { get; set; }

            public Market(string name, List<string> address, string description, string phonenumber, string email)
            {
                Name = name;
                Address = address;
                Description = description;
                phoneNumber = phonenumber;
                Email = email;
            }

            public void Show()
            {
                Console.WriteLine($"Name: {Name}, Description: {Description}, Phone: {phoneNumber}, Address: {Address}, Email: {Email}");
            }

            public void addAddress(string address)
            {
                Address.Add(address);
            }

        }


        static void main(string[] args)
        {
            // დავალება 2-ის ინფუთი
            //WebPage myPage = new WebPage("Giorgi's Portfolio", "kiu.edu.ge", "My Projects", "197.31.31.21");
            //myPage.showWebPage();
            //myPage.goToWebPage();
            //Console.WriteLine(myPage.getIPAddress());


        }
    }
}
