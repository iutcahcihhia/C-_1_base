using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] arr = new Figure[5];
            try
            {
                arr[0] = new Circle(); //у круга максимум 1 параметр - радиус
                Console.WriteLine(arr[0].Info);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            try
            {
                arr[1] = new Rectangle(); //у прямоугольника - максимум 2 параметра - стороны
                Console.WriteLine(arr[1].Info);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            try
            {
                arr[2] = new Triangle(); //у треугольника максимум 3 параметра - стороны
                Console.WriteLine(arr[2].Info);
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            
            
            Console.ReadKey();
        }
    }
}
