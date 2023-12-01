using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDaForca
{
    public static class InterfaceUsuario
    {
        public static void ImprimirMensagemInicial()
        {
            Console.WriteLine("JOGO DA FORCA\n");
            Console.WriteLine("Tente descobrir a palavra-chave que irá salvar nosso amigo da forca" +
                              "\nVocê deverá tentar adivinhar letra por letra até descobrir qual é a palavra \n");

        }

        public static void ImprimirForca(int quantidadeErros)
        {
            switch (quantidadeErros)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor(); Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |         /|");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |         /|");
                    Console.WriteLine("    |         / ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |         /|\\");
                    Console.WriteLine("    |         / ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |         /|\\");
                    Console.WriteLine("    |         / \\");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }

        public static void ImprimirPalavraDica(Palavra palavra)
        {
            Console.WriteLine($"Dica: {palavra.dica}");
            Console.WriteLine(palavra.letrasAdivinhadas);
        }

    }
}
