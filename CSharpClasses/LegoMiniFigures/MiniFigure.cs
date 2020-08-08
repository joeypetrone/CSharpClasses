using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.LegoMiniFigures
{
    class MiniFigure
    {
        //properties
        public string HairColor { get; set; }
        public string HeadType { get; set; }
        public string TorsoType { get; set; }
        public string LegType { get; set; }

        //fields
        public List<string> accessories = new List<string>();


        public void AddAccessories()
        {
            bool addingAccessories = true;
            do
            {
                Console.WriteLine("Type in the accessory you would like to add.");
                accessories.Add(Console.ReadLine());

                Console.WriteLine(" ");
                Console.WriteLine("Would you like to add another accessory?");
                var addAnother = Console.ReadLine();

                if (addAnother.ToLower() == "no" || addAnother.ToLower() == "n")
                {
                    addingAccessories = false;
                }

                Console.WriteLine(" ");

            } while (addingAccessories);
        }

        public void ViewAccessories()
        {
            Console.WriteLine("Your accessories are:");
            foreach(var accessory in accessories)
            {
                Console.WriteLine($"{accessory}");
            }

            Console.WriteLine(" ");
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void DoubleJump()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public void Look()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
