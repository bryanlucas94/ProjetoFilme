using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;

        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public void Logar()
        {
            Console.WriteLine("Logando . . . ");
        }

        public void Logar(string codigo)
        {
            Console.WriteLine("Logando com cod . . .");
        }

        public void Logar(string email, string senha)
        {
            Console.WriteLine("Logando com email e senha . . .");
        }

        public virtual void Exibir()
        {
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Senha: {senha}");
        }
    }

    class Aluno : Usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";

        public Aluno(string turno, string nome, string email, string senha): base(nome, email, senha)
        {
            this.turno = turno;
        }
        public override void Exibir()
        {
            Console.WriteLine("Dados do aluno: ");
            base.Exibir();
            Console.WriteLine("Turno: " + turno);
        }
    }

    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();

        public Zelador(string nome, string email, string senha): base(nome, email, senha)
        {
            
        }
    }
}
