using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(!escolheuSair) // Enuanto o usuario NÃO(!) escolher sair exiba o Menu
            {
                Console.WriteLine("Calculadora\nSelecione uma das opçoes abaixo");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                /* string opcaotxt = console.ReadLine();
                 int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (menu)opcaoInt; */

                Menu Opção = (Menu)int.Parse(Console.ReadLine());
               ;

                switch (Opção)
                {
                    case Menu.Subtração:
                        Subtração();
                        break;
                    case Menu.Divisão:
                        Divisão();
                        break;
                    case Menu.Multiplicação:
                        Multiplicação();
                        break;
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Potencia:
                        Potenciação();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                   

                }
                Console.Clear(); //Clear serve para limpar o codigo.


            } 

      



        }
        static void Soma()
        {
            Console.WriteLine("Soma ");
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Subtração()
        {
            Console.WriteLine(" Subtração: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 - numero2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Divisão()
        {
            Console.WriteLine(" Divisão: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            float resultado = (float)numero1/(float)numero2; // caso tenha um numero uebrado, ele converte o numero
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Multiplicação()
        {
            Console.WriteLine("Multiplicação: ");
            Console.WriteLine("Digite o primeiro numero: ");
           int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 * numero2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Potenciação()
        {
            Console.WriteLine(" Potenciação: ");
            Console.WriteLine("Digite a base ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expoente);
            /* no c# existem 3 tipos de numeros decimais Float / (6 a 9 numeros depois da casa decimal)
             Double (15 a 17 numeros)
             Decimal (28 a 29 digitos) */
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz: ");
            Console.WriteLine("Digite o numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(numero1);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();
        }


    }

}
