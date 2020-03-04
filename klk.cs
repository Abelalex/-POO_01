using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_v02
{

    class APARTAMENTO
    {

        public string direccion;
        public string color;
        public string área_construcción;
        public string parqueos;
        public string habitaciones;
        public string baños;
        public APARTAMENTO()
        {

            Console.WriteLine("En que locacion le gustaria vivir?");
            direccion = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("De que color le gustaria su vivienda?");
            color = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Que tan grande le gustaria que fuera su casa?");
            área_construcción = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Cuantos parqueos le gustaria que tuviera?");
            parqueos = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Cuantas habitaciones le gustaria que tuviera?");
            habitaciones = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Cuantas Baños le gustaria que tuviera?");
            baños = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Leyendo informacion");



        }
        public void Vender()
        {
            Console.WriteLine("La locacion que le gustaria es " + direccion);
            Console.WriteLine("");
            Console.WriteLine("El color que le gustaria es " + color);
            Console.WriteLine("");
            Console.WriteLine("La locacion que le gustaria es " + área_construcción);
            Console.WriteLine("");
            Console.WriteLine("La locacion que le gustaria es " + parqueos);
            Console.WriteLine("");
            Console.WriteLine("La locacion que le gustaria es " + habitaciones);
            Console.WriteLine("");
            Console.WriteLine("La locacion que le gustaria es " + baños);
            Console.WriteLine("");
        }

        public void Alquiler()
        {
            Console.WriteLine("La direccion de la casa que quiere comprar es: " + direccion);
            Console.WriteLine("");
            Console.WriteLine("El color de la casa que desea es:" + color);
            Console.WriteLine("");
            Console.WriteLine("Esta casa mide: " + área_construcción);
            Console.WriteLine("");
            Console.WriteLine(" La casa tiene " + parqueos + "parqueos" );
            Console.WriteLine("");
            Console.WriteLine(" La casa tiene " + habitaciones + "habitaciones");
            Console.WriteLine("");
            Console.WriteLine(" La casa tiene " + baños + "baños");
            Console.WriteLine("");
        }
    }
}
