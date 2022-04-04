using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Filme
    {
        public string nome;
        public string desc;
        public int ano;
        public string studio;
        public List <string> atores = new List<string>();

        public void Executar()
        {
            Console.WriteLine("Rodando filme: " +nome);
        }
        public void Pausar()
        {
            Console.Write("| |");
        }
    }
}
