using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.LegoMiniFigures
{
    class LegoMiniFigures
    {
        public void Run()
        {
            bool doneWithLegos = false;
            do
            {
                Console.WriteLine("You are in Lego Mini-Figures!");

                Console.WriteLine(" ");

                var newLegoFigure = new MiniFigure()
                {
                    HairColor = "green",
                    HeadType = "construction worker",
                    TorsoType = "coveralls",
                    LegType = "coveralls"
                };

                newLegoFigure.AddAccessories();

                newLegoFigure.ViewAccessories();

                Console.WriteLine("Would you like to run the Legos Mini-Figures console app again?");
                var runAgain = Console.ReadLine();
                if (runAgain.ToLower() != "n" || runAgain.ToLower() != "no")
                {
                    doneWithLegos = false;
                }
                else
                {
                    doneWithLegos = true;
                }
            } while (doneWithLegos == true);
        }

    }
}
