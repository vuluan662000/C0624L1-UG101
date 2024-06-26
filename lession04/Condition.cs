namespace lession04;
using System.Text;
class Condition
{
    static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // bool gender = true;
            // bool married = true;
            // string name = "binh";
            // if(gender)
            // {
            //     Console.WriteLine("Mrs.{name}");
                
            // } 
            // else if(married)               
            //     {
            //         Console.WriteLine($"Mrs.{name}");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Ms.{name}");
            //     }

                /*
            hiển thị số lớn nhất
            int max = number_1;
            if (max < number_2) max = number_2;
            if (max < number_3) max = number_3; 
            Console.WriteLine("max:"+max) ;
             */    

            // giải phương trình bậc 2
            Console.Write("Nhap a:");
            double number_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b:");
            double number_b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c:");
            double number_c = Convert.ToDouble(Console.ReadLine());             
            if(number_a == 0) 
            {
                Console.WriteLine($"nghiệm của phương trình là: x= {-(number_c/number_b)}");
            }
            else
            {
                double delta = (number_b * number_b)-(4 * number_a * number_c);
                Console.WriteLine("delta:" + delta);
                double sqrtDelta = Math.Sqrt(delta);
                Console.WriteLine($"căn delta: {sqrtDelta}");
                if(delta > 0)
                {
                    Console.WriteLine($"nghiệm của phương trình là: x= {(-number_b + sqrtDelta) / (2 * number_a)}, y= {(-number_b - sqrtDelta) / (2 * number_a)}") ;                            
                }
                if(delta == 0)
                {
                    Console.WriteLine($"nghiệm của phương trình là: x = y = {-number_b/(2 * number_a)}") ; 
                }
                if(delta < 0)
                {
                    Console.WriteLine("phương trình vô nghiệm") ;
                }
            }
         }   
}