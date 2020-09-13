using System;

namespace treciZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite jedan broj: ");
            int broj;
            broj = Convert.ToInt32(Console.ReadLine());
            if (broj % 4 == 0 && broj % 6 != 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4");
            }
            else if(broj % 6 == 0 && broj % 4 != 0)
            {
                Console.WriteLine("Broje je djeljiv sa 6");
            }
            else if(broj % 4 ==0 && broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
            }
            else
            {
                Console.WriteLine("Broj nije dijeliv ni sa 4 ni sa 6");
            }
        }
    }
}
