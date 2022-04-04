using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Aluno a = new Aluno("Matutino", "Bryan", "bryan@udemy.com", "12345");
            Zelador z = new Zelador("Daniel", "daniel@udemy.com", "123456");
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(a);
            usuarios.Add(z);
            a.Exibir();*/

            IDrawable shape = new Line();
            shape.Draw();

            Console.ReadLine();
        }
    }

     abstract class Drawable
    {
        public int size;
        public int color;
        public abstract void Draw();

        public abstract float Area();

    }

    interface IDrawable
    {

        void Draw();
        float Area();
    }

    class Line : IDrawable
    {
        public float Area()
        {
            return 20;
        }

        public void Draw()
        {
            Console.WriteLine("- Linha -");
        }
    }

    class Quad : IDrawable
    {
        public float Area()
        {
            return 2;
        }

        public void Draw()
        {
            Console.WriteLine("- Quad -");
        }
    }

    class Rect : IDrawable
    {
        public float Area()
        {
            return 10;
        }

        public void Draw()
        {
            Console.WriteLine("- Rect -");
        }
    }
}
