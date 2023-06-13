using System;
using System.Threading;
using System.Threading.Tasks;

namespace taskResult
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildAsync task = new ChildAsync();
            //int a = task.RunTaskAAsync().Result;
            //Console.WriteLine(a);

            //Console.WriteLine(task.RunTaskAAsync().Result);
            //Console.WriteLine(task.RunTaskB());

            Console.WriteLine(task.MyHttpGetAsync("https://www.google.com").Result);
        }
    }
}
