using System;
using System.Threading;

namespace Thread_Id
{
    class Program
    {
       static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start(i);
            }

            Console.WriteLine("Programa finalizado");
            Console.ReadKey();
        }

        static void ThreadRepeticao(object Id) {

            for (int i = 0; i < 1000; i++) {
                Console.WriteLine("Thread:" + Id + " - Num: " + i + " - Managed Thread Id:" + Thread.CurrentThread.ManagedThreadId);
            }

        }
    }
}
