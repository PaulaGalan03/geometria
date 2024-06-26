using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    class Resultado
    {
        //Mostramos el resultado y mostramos nuevamente el menú 
        public double resultado;

        public double mostrar_resultado(double result)
        {
            Areas a = new Areas();
            resultado = result;
            Console.WriteLine("El resultado es");
            Console.WriteLine(resultado);
            Console.WriteLine("/////////////////////////////////");
            Menu men = new Menu();
            men.mostrar_menu();
            return 0;
        }
    }
}
