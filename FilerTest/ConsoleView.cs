using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilerTest
{
    class ConsoleView : IView_Filer
    {
        public void Start()
        {
            Console.Clear();
        }
        public int ChooseList(string prompt = "")
        {
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());
        }
        public string ChooseMap(string prompt = "")
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public void Display<T>(T message)
        {
            Console.WriteLine(message);
        }
        public void Stop()
        {
            Console.ReadKey();
        }
    }
}
