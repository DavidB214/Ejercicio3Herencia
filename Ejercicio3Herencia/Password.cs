using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3Herencia
{
    public class Password
    {
        const int longitudD = 8;
        int _longitud;
        String _contraseña;

        public Password() :this(longitudD)
        {

        }
        public Password(int longitud)
        {
            _contraseña = generarPassword(longitud);
        }

        public int Longitud { get => _longitud; set => _longitud = value; }
        public string Contraseña { get => _contraseña;}
    
            
        public Boolean esFuerte()
        {
            int mayus = 0, minus = 0, number = 0;
            char[] pass = this._contraseña.ToCharArray();
            for (int i = 0; i < pass.Length; i++)
            {
                switch (pass[i])
                {
                    case char n when (n >= 'A' && n <= 'Z'):mayus++; break;
                    case char n when (n >= 'a' && n <= 'z'):minus++; break;
                    case char n when (n >= '0' && n <= '9'):number++; break;
                }
                
            }
            if (mayus > 2 && minus > 1 && number > 5) 
                return true;
            return false;
        }
        private String generarPassword(int longitud)
        {
            String pas = "";
            Random r = new Random();
            for (int i = 0; i < longitud; i++)
            {
                int random = r.Next(1, 4);
                switch (random)
                {
                    case 1:pas += (char)r.Next('A','Z'); break;
                    case 2:pas += (char)r.Next('a', 'z'); break;
                    case 3:pas += r.Next(0, 9);break;
                }
            }
            return pas;
        }
    }
}
