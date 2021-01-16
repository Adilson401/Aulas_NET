 using System;

namespace DigitalInnovationOne
{
    class Tipodados
    {
 static void Main(string[] args)
        {
            int numerDevezes =6;

            for( int i=0; i< numerDevezes; i++)
            {
                Console.WriteLine($"Seja Bem-Vindo .NET{i}");
            }
        }
        static void  Declaracaoes(string[] args)
        {
            int a;
            int b=2, c=4;
            const int d=4;
            a=1;
            a=2;
            Console.WriteLine(a+b+c+d);

        }
        static void InstrucaoIf(string[] args)
        {
            if(args.Length==0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if(args.Length==1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numerDeArgumentos=args.Length;
            switch(numerDeArgumentos)
            {
                case 0:
                Console.WriteLine("Nunhum argumento");
                break;
                case 1:
                Console.WriteLine("Um argumento");
                break ;
                default: 
                Console.WriteLine($"{numerDeArgumentos} argumentos");
                break;
            }
        }

        static void InstrucaoWhile(string[] args)
        {
            int i=0;
            while(i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++; //vai definir a prosicao 
            }

        }
        static void InstrucaoDO(string[] args)
        {
            string texto;
            do{
                texto=Console.ReadLine();
                Console.WriteLine(texto);
            }while(!string.IsNullOrEmpty(texto));//I esta definir a negação d
        }
        static void InstrucaoForeach(string[] args)
        {

        }
    }
}
