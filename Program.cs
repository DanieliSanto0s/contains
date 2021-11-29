using System;

namespace CONTAINS
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "frase teste para realizar a atividade";
            string s2 = "tarefa";
            string s3 = "atividade";

            Console.WriteLine("A frase será falsa por não possuir a palavra TAREFA :{0} ", s1.Contains(s2));

            Console.WriteLine("A frase será verdadeira, pois na frase se apresenta a palavra ATIVIDADE :{0} ", s1.Contains(s3));
        }
    }
}
