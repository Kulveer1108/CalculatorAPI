using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Action : ");
            string Action = Console.ReadLine();

            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:7025/Calculator?number1=" + number1 + "&number2=" + number2 + "&Action=" + Action);

            var responseContent = response.Result;

            Console.WriteLine(responseContent.Content.ReadAsStringAsync().Result);
        }
    }
}
