using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Furniture
    {
        protected int price;
        protected String material;
        public void getDetails()
        {
            Console.WriteLine("Enter Price : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Material : ");
            material = Console.ReadLine();
        }
    }
    public class Table : Furniture
    {
        double surface_area;
        double Height;

        public void getTabelDetails()
        {
            Console.WriteLine("Enter Height : ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Surface Area  : ");
            surface_area = Convert.ToDouble(Console.ReadLine());

        }

        public void displayTabel()
        {
            Console.WriteLine($"Furniture Price is : {price} with Material : {material} and Height is : {Height} Surface Area  : {surface_area}");
        }
    }
}
