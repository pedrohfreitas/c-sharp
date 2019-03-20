using System;

namespace Delegate_Basic
{
    class Program
    {
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            /* Tradicional */
            // var so = Soma(20,30);
            // var su = Subtrair(50,60);

            /* Delegates */
            Calcula calc = new Calcula(Soma);
            var so = calc(10,20);

            Calcula calc1 = new Calcula(Subtrair);
            var su = calc1(30,60);

            Console.WriteLine("Soma: " + so);
            Console.WriteLine("Sub: " + su);

            Console.ReadKey();
        }
        static int Soma(int a, int b){
            return a + b;
        }
        static int Subtrair(int a, int b){
            return a - b;
        }
    }
}
