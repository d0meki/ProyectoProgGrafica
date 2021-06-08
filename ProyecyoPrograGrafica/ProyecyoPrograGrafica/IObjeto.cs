using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
namespace ProyecyoPrograGrafica
{
    interface IObjeto
    {
        
        void rotar();
        void mover(Vector3 direccion);
        void redimencionar(Vector3 escala);

    }
}
