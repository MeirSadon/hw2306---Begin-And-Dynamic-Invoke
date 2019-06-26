using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2306___TaskGetPie___Exrice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<float> myFunc = new Func<float>(GetPie);
            Task.Run(() => { Console.WriteLine(myFunc()); });
            Console.ReadLine();
        }
        static float GetPie()
        {
            return 3.14f;
        }
    }
}