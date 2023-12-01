using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public class Palavra
    {
        public string palavra = "golfinho";
        public string dica = "Mamífero marinho com 8 letras.";
        public string letrasAdivinhadas = "________";

        public void ModificarLetraAdivinhada(int indice, char novaLetra)
        {
            if (indice >= 0 && indice < letrasAdivinhadas.Length)
            {
                char[] letrasArray = letrasAdivinhadas.ToCharArray();
                letrasArray[indice] = novaLetra;
                letrasAdivinhadas = new string(letrasArray);
            }
        }
        public bool TodasLetrasAdivinhadas()
        {
            return !letrasAdivinhadas.Contains('_'); // Verifica se ainda há underscores na array
        }
    }
}
