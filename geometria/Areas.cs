using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    //Operaciones para hallar el área de cada figura
     
    class Areas
    {
        //variables

        public double Base, BaseM, BaseMn, Altura, resultado = 0;

        public Resultado r = new Resultado();


        public double Rectangulo()
        {
            Console.WriteLine("Ingrese los datos");
            Console.WriteLine("Ingrese la base");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            Altura = Convert.ToDouble(Console.ReadLine());
            resultado = Base * Altura;
            Console.WriteLine(resultado);
            return r.mostrar_resultado(resultado);
        }
        public double Triangulo()
        {
            Console.WriteLine("Ingrese los datos");
            Console.WriteLine("Ingrese la base");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            Altura = Convert.ToDouble(Console.ReadLine());
            resultado = ((Base * Altura) / 2);
            Console.WriteLine(resultado);
            return r.mostrar_resultado(resultado);
        }
        public double Trapecio()
        {
            Console.WriteLine("Ingrese los datos");
            Console.WriteLine("Ingrese la base mayor");
            BaseM = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la base menor");
            BaseMn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            Altura = Convert.ToDouble(Console.ReadLine());
            resultado = (((BaseM + BaseMn)  / 2) * Altura);
            Console.WriteLine(resultado);
            return r.mostrar_resultado(resultado);
        }
    }
}
