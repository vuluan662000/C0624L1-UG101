namespace lession04;

class SwitchCase
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so");
        int month =  Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
            case 1:
                Console.Write("thu 2");          
                break;
            case 2:  
                Console.Write("thu 3");          
                break;
            case 3:
                Console.Write("thu 4");
                 break ;             
            case 4:
                Console.Write("thu 5");
                 break ;
            case 5:
                Console.Write("thu 6");
                
                 break ;
            case 6:
                Console.Write("thu 7");
                 break ;
            case 7:
                Console.Write("chu nhat");
                 break ;
            default:
                 Console.WriteLine("nhap tu 1-7:");
                 break ;
        }
    }
}