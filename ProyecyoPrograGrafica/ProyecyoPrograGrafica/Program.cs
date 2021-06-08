using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace ProyecyoPrograGrafica
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow ventana = new GameWindow(1024, 480);
            ventana.Title = "------------------------------------ESCENARIO------------------------------------";
            Ventana mostrar = new Ventana(ventana);
        }
    }
}
