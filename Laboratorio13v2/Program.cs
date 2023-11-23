using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio13v2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = Pantallas.pantallaPrincipal();
                        break;
                    case 1:
                        opcion = Pantallas.encuesta();
                        break;
                    case 2:
                        opcion = Pantallas.verDatos();
                        break;
                    case 3:
                        opcion = Pantallas.elimininarDatos();
                        break;
                    case 4:
                        opcion = Pantallas.ordenarDatos();
                        break;
                    
                }
            } while (opcion != 5);

        }
    }
}
