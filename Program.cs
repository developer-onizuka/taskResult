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
            Console.WriteLine(task.RunTaskAAsync().Result);
            //int a = x.RunTaskAAsync().Result;
            //Console.WriteLine(a);
            Console.WriteLine(task.RunTaskB());
        }
    }
}
