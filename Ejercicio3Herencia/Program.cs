using System;

namespace Ejercicio3Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el tamaño de el array..");
            int l = int.Parse(Console.ReadLine());
            Password[] p = new Password[l];
            Console.WriteLine("Indique la longitud de las contraseñas");
            int n= int.Parse(Console.ReadLine());
            Boolean[] strong = new Boolean[l];
            for (int i = 0; i < l; i++)
            {
                p[i] = new Password(n);
                strong[i] = p[i].esFuerte();
                Console.WriteLine("contraseña" + (i + 1) + " " + p[i].Contraseña + "_" + strong[i]);
            }
        }
    }
}
