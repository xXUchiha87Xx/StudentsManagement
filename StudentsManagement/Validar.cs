using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsManagement
{
    class Validar
    {
        public static bool SoloLetras(string Caracteres)
        {
            //comprueba si en la cadena de caracteres introducida hay algun numero
            // y mientras haya algun numero en Caracteres seguira retornando false
            //el punto (.) es un caracter
            foreach (char Letra in Caracteres)
            {
                if (!Char.IsLetter(Letra) && Letra != 32)
                {
                    return false;
                }
            }
            return true;
        }

        public static string QuitaEspaciosDelMedio(string Cadena)
        {
            string Solo1Espacio = string.Empty;
            bool EspacioMedio = false;
            int Contador = 0;

            for (int x = 0; x < Cadena.Length; x++)
            {
                if (Cadena[x] == ' ' && Contador >= 3 && EspacioMedio == false)
                {
                    Solo1Espacio += ' ';
                    EspacioMedio = true;
                }

                if (Cadena[x] != ' ' && Cadena[x] != '.')
                {
                    Contador++;
                    Solo1Espacio += Cadena[x].ToString();
                }

            }
            return Solo1Espacio;
        }


    }
}
