using System;
using System.Threading;

namespace Thread_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sleep
            Console.WriteLine("Inicio do programa - " + DateTime.Now);
            Thread.Sleep(3000);
            Console.WriteLine("Fim do programa - " + DateTime.Now);
            
            //Join
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();
            t1.Join();

            Console.WriteLine("Fim do Join - " + DateTime.Now);

            Console.ReadKey();
        }

        static void ThreadRepeticao() {

            for (int i = 0; i < 20; i++) {
                Console.WriteLine("Num: " + i);
            }

            Console.WriteLine("DateTime: " + DateTime.Now);
        }
    }
}
