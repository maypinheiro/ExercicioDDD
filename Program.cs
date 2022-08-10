using System;

namespace ExercicioDDD
{
    class Program
    {

        static void Main(string[] args)
        {
            Ddd verificadd = new Ddd();
            int ddd = int.Parse(Console.ReadLine());
            Console.WriteLine(verificadd.VerificaDDD(ddd));
            Console.ReadKey();
        }
    }
}