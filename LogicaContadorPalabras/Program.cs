using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaContadorPalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cadenaTexto = "Es un hecho establecido hace demasiado tiempo que un lector" +
                " se distraerá con el contenido del texto de un sitio mientras que mira su " +
                "diseño. El punto de usar Lorem Ipsum es que tiene una distribución más o " +
                "menos normal de las letras, al contrario de usar textos como por ejemplo." +
                " Estos textos hacen parecerlo un español que se puede leer. Muchos paquetes " +
                "de autoedición y editores de páginas web usan el Lorem Ipsum como su texto " +
                "por defecto, y al hacer una búsqueda de."; // creo una variable implicita que obviamente toma el valor de tipo STRING con un texto X ...

            Console.WriteLine(cadenaTexto);//vuelvo a escribir la cadena de texto

            string[] arregloPalabras = cadenaTexto.Split(' ');//creo un arreglo en base al string de arriba donde el separador es el espacio ' ' 
            


            Console.WriteLine("///////////////////////////////////////");//bueno escribo en consola para ver
            Console.WriteLine("Primera palabra del arreglo: " + arregloPalabras[0]);  //escribo el primer elemento que obvio tiene indice cero en el arreglo
            Console.WriteLine("Segunda palabra del arreglo: " + arregloPalabras[1]);

            int i = 0;
            foreach (var item in arregloPalabras)
            {
                Console.Write("["+arregloPalabras[i]+"] ");
                i++;
            }
            Console.WriteLine("la cantidad de palabras es: "+ i);
            //Listo en teoria ya tenemos la logica ^^ 

            #region Comunes de espera
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("presione <enter> para salir");
            Console.ReadKey();
            #endregion
        }
    }
}
