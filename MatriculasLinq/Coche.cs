using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculasLinq
{
   public class Coche
    {
       public String Modelo { get; set; }
       public String Matricula { get; set; }
       public int Fabricacion { get; set; }

        public override string ToString()
        {
          //  return $"{Modelo} con maricula {Matricula} fabricado en {Fabricacion}";
          return String.Format("{0} con maricula {1} fabricado en {2}",
              Modelo,Matricula,Fabricacion);
        }
        
    }
}
