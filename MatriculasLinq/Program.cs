using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculasLinq
{
    class Program
    {
        static List<Coche> lista=new List<Coche>()
        {
            new Coche() {Fabricacion = 2012,Matricula = "2121BBB",Modelo = "Seat ibiza"},
            new Coche() {Fabricacion = 2010,Matricula = "2121BBC",Modelo = "Seat cordoba"},
            new Coche() {Fabricacion = 2011,Matricula = "2121BBD",Modelo = "Seat Leon"},
            new Coche() {Fabricacion = 2012,Matricula = "2121BBZ",Modelo = "Seat Basurilla"},
            new Coche() {Fabricacion = 2011,Matricula = "2121BBJ",Modelo = "Seat No anda"},
            new Coche() {Fabricacion = 2011,Matricula = "2121BBK",Modelo = "Seat Leon"},
            new Coche() {Fabricacion = 2012,Matricula = "2121BBI",Modelo = "Seat ibiza"},
        }; 

        static void Main(string[] args)
        {
            int r = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Matricula");
                Console.WriteLine("2. Fabricacion");
                Console.WriteLine("3. Modelo");
                Console.WriteLine("4 Salir");
                Console.Write("Eleccion:");
                r = Convert.ToInt32(Console.ReadLine());

                switch (r)
                {
                    case 1:
                        matricula();
                        break;
                    case 2:
                        fabricacion();
                        break;
                    case 3:
                        modelo();
                        break;
                }

            } while (r != 4);

        }

        private static void modelo()
        {
            Console.Write("Fabricado en:");
            var f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Modelo:");
            var m = Console.ReadLine();

            var data = lista.Where(o => o.Fabricacion == f &&
                                    o.Modelo == m)
                .OrderByDescending(o => o.Matricula);

            foreach (var coch in data)
            {
                Console.WriteLine(coch);
            }

        }

        private static void fabricacion()
        {
            Console.Write("Fabricado en:");
            var f = Convert.ToInt32(Console.ReadLine());

            var data = lista.Where(o => o.Fabricacion == f)
                .OrderByDescending(o => o.Modelo)
                .ThenByDescending(o => o.Matricula);

            if(!data.Any())
                Console.WriteLine("Ningun coche disponible");


            foreach (var coch in data)
            {
                Console.WriteLine(coch);
            }


        }


        private static void matricula()
        {
            Console.Write("Matricula:");
            var m = Console.ReadLine();

            try
            {
                var v = lista.First(o => o.Matricula==m);
                Console.WriteLine(v);
            }
            catch (Exception e)
            {
                Console.WriteLine("Vehiculo no encontrado");
            }


            //if(v!=null)
            //    Console.WriteLine(v);
            //else
            //{
            //    Console.WriteLine("Vehiculo no encontrado");
            //}


        }
    }
}
