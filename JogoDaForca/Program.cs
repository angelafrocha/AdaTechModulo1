namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {


                int quantidadeErros = 0;
                Palavra palavra = new Palavra();

                do
                {
                    Console.Clear();
                    InterfaceUsuario.ImprimirMensagemInicial();

                    InterfaceUsuario.ImprimirForca(quantidadeErros);


                    InterfaceUsuario.ImprimirPalavraDica(palavra);

                    Console.WriteLine($"Erros: {quantidadeErros}, tentativas restantes: {7 - quantidadeErros}");
                    char letra = LerLetra("Digite uma letra");


                    bool letraAdivinhada = false;
                    for (int i = 0; i < palavra.palavra.Length; i++)
                    {
                        if (letra == palavra.palavra[i])
                        {
                            palavra.ModificarLetraAdivinhada(i, letra);
                            letraAdivinhada = true;
                        }
                    }
                    if (!letraAdivinhada)
                    {
                        quantidadeErros++;
                    }
                }
                while (quantidadeErros < 7 && !palavra.TodasLetrasAdivinhadas());

                if (quantidadeErros >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("VOCÊ PERDEU!");
                    Console.ResetColor();
                }
                else if (palavra.TodasLetrasAdivinhadas() == true)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PARABÉNS! VOCÊ VENCEU!");
                    Console.WriteLine($"Palavra adivinhada: {palavra.palavra}");
                    Console.ResetColor();
                }

           
            Console.WriteLine("\nDeseja jogar novamente? (Digite 's' para sim ou qualquer outra tecla para sair)");

            } 
            while (Console.ReadLine()!.ToLower() == "s");
        }


        public static char LerLetra(string prompt)
        {
            char letra = '\0';
            bool letraValida = false;

            do
            {
                Console.Write($"\n{prompt}: \n");
                string input = Console.ReadLine()!;

                if (input.Length == 1 && char.IsLetter(input[0]))
                {
                    letra = char.ToLower(input[0]);
                    letraValida = true;
                }
                else
                {
                    Console.WriteLine("Você não digitou uma letra válida. Tente novamente.");
                }

            } while (!letraValida);

            return letra;

        }

    }

}
