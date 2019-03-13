using System;
using System.Threading;

namespace Thread_Safe
{
    class Program
    {
        static int Rede = 0;
        static object variavelDeControle = 0;

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

            //O Lock trabalha com uma fila (Primeiro a entrar é o primeiro a sair)
            lock(variavelDeControle){

                for (int i = 0; i < 20; i++) {
                    Console.WriteLine("Num: " + i);
                    Rede++;
                }
            }

            Console.WriteLine("DateTime: " + DateTime.Now);
        }
    }
}
