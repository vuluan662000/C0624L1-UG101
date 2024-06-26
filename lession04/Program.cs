
using System;
using System.Text;
namespace lession04;

    class Program
  
    {
        static void Main(string[] args)
        {
            // Console.InputEncoding = Encoding.Unicode;
            // Console.OutputEncoding = Encoding.Unicode;

            // Console.WriteLine("xin chào anh em");
            // Console.ReadLine();

            // Console.Write("Enter your age:");
            // string age = Console.ReadLine();
            // Console.WriteLine("your age: " + age);

            // Console.Write("Enter num1:");
            // int number_1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter num2:");
            // int number_2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"{number_1}+{number_2} = {number_1 + number_2}");

            //    Console.Write("Nhap a:");
        //    var a = int.Parse(Console.ReadLine());
        //    Console.Write("Nhap b:");
        //     var b = int.Parse(Console.ReadLine());
        //    Console.Write("Nhap c:");
        //    var c = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"{a}x2 + {b}x + {c} = 0");

            // Console.Write("Nhap a:");
            // var a = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Nhap b:");
            // var b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"dien tich la: {a*b}");
            // Console.WriteLine($"Chu vi la: {(a+b)*2}");

            // Console.Write("Nhap ban kinh:");
            // var r = Convert.ToDouble(Console.ReadLine());
            // const double pi = 3.14;
            // Console.WriteLine($"Chu vi la: {2*pi*r}");
            // Console.WriteLine($"dien tich la: {pi*(r*r)}");

            // Console.Write("Nhap can nang:");
            // double weight = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Nhap chieu cao:");
            // double height = Convert.ToDouble(Console.ReadLine());
            // double bmi = weight / (height*height);
            // Console.WriteLine($"Chi so BMI: " + bmi);

            bool gender = false;
            bool married = true;
            string name = "binh";
            if(gender)
            {
                Console.WriteLine("Mrs.{name}");
            } 
            else if(married)               
                {
                    Console.WriteLine($"Mrs.{name}");
                }
                else
                {
                    Console.WriteLine($"Ms.{name}");
                }
        }
    }  

