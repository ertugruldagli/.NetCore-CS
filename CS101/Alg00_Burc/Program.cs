internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dogum ayinizi giriniz: ");
        int ay = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dogum gunu giriniz: ");
        int gun = Convert.ToInt32(Console.ReadLine());

        if(ay==1 | ay == 01)
        {
            if(gun>=1 && gun <= 31)
            {
                if (gun <= 22)
                {
                    Console.WriteLine("Burcunuz Oglaktır.");
                }
                else
                {
                    Console.WriteLine("Burcunuz kovadir.");
                }
                       
            }
        }
        else if(ay==2 | ay == 02)
        {
            if(gun>=1 && gun <= 29)
            {
                if (gun <= 19)
                {
                    Console.WriteLine("Burcunuz kovadır.");
                }
                else {
                    Console.WriteLine("Burcunuz Baliktir."); 
                }
            }
        }

        Console.ReadKey();
    }
}