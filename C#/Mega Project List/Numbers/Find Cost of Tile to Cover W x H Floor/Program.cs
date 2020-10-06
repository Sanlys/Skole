using System;

namespace Find_Cost_of_Tile_to_Cover_W_x_H_Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input price per m^2");
            double pricem2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input width of floor in meters");
            double floorArea = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input length of floor in meters");
            floorArea *= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(floorArea * pricem2);
        }
    }
}