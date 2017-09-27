using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;
            while (ProgramContinue == true)
            {

                Double Lenght;
                Console.WriteLine("Enter lenght of room ");
                Lenght = double.Parse(Console.ReadLine());

                Double Width;
                Console.WriteLine("Enter width of room");
                Width = double.Parse(Console.ReadLine());

                Double Area;
                Area = Lenght * Width;
                Console.WriteLine("The Area is");
                Console.WriteLine(Area);


                Double Perimeter;
                Perimeter = (Lenght * 2) + (Width * 2);
                Console.WriteLine("The Perimeter is");
                Console.WriteLine(Perimeter);


                Console.WriteLine("Do you want to continue? Enter Y or N");
                string UserInput;
                UserInput = Console.ReadLine();

                if (UserInput == "N")

                {
                    ProgramContinue = false;
                }









            }
        }

    }
}
