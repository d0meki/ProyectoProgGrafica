using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProyecyoPrograGrafica
{
    class Escenario
    {
        Hashtable listaDibujos;
        public Escenario() {
             this.listaDibujos = new Hashtable();
        }
        public void agregarDibujo(string nombre, Objeto dibujo) {
            
            this.listaDibujos.Add(nombre, dibujo);
        }
        public void dibujarEscenario() {
                foreach (Objeto dibujos in listaDibujos.Values)
                {
                    dibujos.dibujarObjeto();
                }
        }
    }
}
