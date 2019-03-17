using System;
using System.Threading;

namespace Thread_AutoManual
{
    class Program
    {
        static AutoResetEvent auto01;
        static ManualResetEvent manual01;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Pausado
            manual01 = new ManualResetEvent(false);
            auto01 = new AutoResetEvent(false);

            // Thread t1 = new Thread(Executa1);
            // t1.Start();

            Thread t2 = new Thread(Executa2);
            t2.Start();

            Thread.Sleep(5000);
            manual01.Set();//Libera
            manual01.Reset();//Revoga - Para novamento o fluxo

            auto01.Set();

            Thread.Sleep(5000);
            manual01.Set();
            auto01.Set();

            Console.ReadKey();
        }

        static void Executa1(){
            Console.WriteLine("01 - Iniciando Executa01 - " + DateTime.Now.ToLongTimeString());
            manual01.WaitOne();//Esperar 
            Console.WriteLine("02 - Em execução 01 Executa01 - " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("03 - Em execução 02 Executa01 - " + DateTime.Now.ToLongTimeString());
            manual01.WaitOne();//Esperar 
            Console.WriteLine("04 - Finalizando Executa01 - " + DateTime.Now.ToLongTimeString());
        }
        static void Executa2(){
            Console.WriteLine("01 - Iniciando Executa02 - " + DateTime.Now.ToLongTimeString());
            auto01.WaitOne();
            Console.WriteLine("02 - Em execução 01 Executa02 - " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("03 - Em execução 02 Executa02 - " + DateTime.Now.ToLongTimeString());
            auto01.WaitOne();
            Console.WriteLine("04 - Finalizando Executa02 - " + DateTime.Now.ToLongTimeString());
        }
    }
}
