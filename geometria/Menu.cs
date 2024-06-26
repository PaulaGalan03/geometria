using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    class Menu
    {
        /*
         * Menú para que el estudiante seleccione la figura a la
         * cual necesita sacar el área.
         */
        public int seleccion = 0;

        public void mostrar_menu()
        {
            Areas a = new Areas();
            Console.WriteLine("Figuras geometricas");
            Console.WriteLine("Por favor seleccione la figura que necesita: ");
            Console.WriteLine("1. Regtangulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Trapecio");
            Console.WriteLine("4. Salir");

            

            do
            {

                seleccion = Convert.ToInt16(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:
                        a.Rectangulo(); 
                        break;

                    case 2:
                        a.Triangulo();
                        break;

                    case 3:
                        a.Trapecio();
                        break;

                    case 4:
                        Console.WriteLine("Gracias por usar el programa");
                        break;

                    default:
                        Console.WriteLine("Ingrese nuevamente");
                        break;
                }
            } while (seleccion != 4);
        }
    }
}
