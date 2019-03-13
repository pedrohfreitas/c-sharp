using System;
using System.Threading;

namespace Thread_Background
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Data de Inicio: " + DateTime.Now);

            for (int i = 0; i < 5; i++) {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true;
                t1.Start();
            }

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
