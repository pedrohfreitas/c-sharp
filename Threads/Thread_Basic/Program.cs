using System;
using System.Threading;

namespace Thread_Basic {
    class Program {
        static void Main (string[] args) {
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();

            for (int i = 0; i < 1000; i++) {
                Console.WriteLine("Main: " + i);
            }

            Console.ReadKey();
        }

        static void ThreadRepeticao() {

            for (int i = 0; i < 1000; i++) {
                Console.WriteLine("Num: " + i);
            }

        }
    }
}