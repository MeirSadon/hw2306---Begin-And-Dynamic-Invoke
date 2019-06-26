using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace hw2306___delagateWithStringFunction___Exrice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string> addWords = new Func<string>(GetWord1);
            addWords += GetWord2;
            addWords += GetWord3;

            string sentence = "";


            //way 1 - Begin And End Invoke.
            //foreach (Func<string> word in addWords.GetInvocationList())
            //{
            //   IAsyncResult ar = word.BeginInvoke(null,null);
            //   sentence += word.EndInvoke(ar);
            //}
            //Console.WriteLine(PrintTheSentence(sentence));

            //Way 2 - Dynamic Invoke.
            foreach (Delegate del in addWords.GetInvocationList())
            {
                sentence += (string)del.DynamicInvoke();
            }
            Console.WriteLine(PrintTheSentence(sentence));


            Console.ReadLine();
        }
        static string GetWord1()
        {
            return "Hello ";
        }
        static string GetWord2()
        {
            return "From ";
        }
        static string GetWord3()
        {
            return "Meir ";
        }
        static string PrintTheSentence(string sentence)
        {
            return sentence;
        }
    }
}
