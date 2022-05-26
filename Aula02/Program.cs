using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);

            string name = "Mario";
            string lastname = " Sergio";
            string fullname = name + lastname;
            Console.WriteLine(fullname);

            int numero = 15;
            Console.WriteLine(numero);

            int numero1;
            numero1 = 20;
            Console.WriteLine(numero1); 

            int numero2 = 30;
            numero2 = 50; // agora é 50
            Console.WriteLine(numero2);

            int numero3 = 300;
            double dnumero = 7.99d;
            float valor1 = 10.75f;
            char letra = 'D';
            bool mybool = true;
            string texto = "Hello";
            long valor = 21551575020l;
            Console.WriteLine(numero3);
            Console.WriteLine(dnumero);
            Console.WriteLine(valor1);
            Console.WriteLine(letra);
            Console.WriteLine(mybool);
            Console.WriteLine(texto);
            Console.WriteLine(valor);

            float f1 = 99e3f; // 99000
            double d1 = 12E5d; //1200000
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            

            int x = 5;
            int y = 6;
            // ou int x=5, y=6;
            Console.WriteLine(x + y);

            int a, b, c;
            a = b = c = 10;
            Console.WriteLine(a + b + c);

            Console.WriteLine("Qual seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é " + nome);

            Console.WriteLine("Qual sua idade? ");
            int idade = Convert.ToInt32(Console.ReadLine()); // ToInt32 é int
            Console.WriteLine("Seu idade é: " + idade);
        }
    }
}
