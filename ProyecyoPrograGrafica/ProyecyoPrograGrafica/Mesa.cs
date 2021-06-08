using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Drawing;
using System.Drawing.Imaging;

namespace ProyecyoPrograGrafica
{
    class Mesa : Objeto, IObjeto
    {
        Hashtable partesMesa;
        public Mesa(Vector3 posicion, float ancho, float alto, float largo) {
            float lar;
            if (ancho > largo)
            {
                lar = ancho;
            }
            else
            {
                lar = largo;
            }
            partesMesa= new Hashtable();
            partesMesa.Add("baseMesa",new Cubo(posicion, ancho, largo, alto * 10 / 100));
            partesMesa.Add("pata1",new Cubo(new Vector3(posicion.X + largo * 10 / 100, posicion.Y - alto * 10 / 100, posicion.Z - ancho * 10 / 100), lar * 10 / 100, lar * 10 / 100, alto - alto * 10 / 100));
            partesMesa.Add("pata2", new Cubo(new Vector3(posicion.X + largo * 10 / 100, posicion.Y - alto * 10 / 100, posicion.Z - ancho + ancho * 10 / 100 + lar * 10 / 100), lar * 10 / 100, lar * 10 / 100, alto - alto * 10 / 100));
            partesMesa.Add("pata3", new Cubo(new Vector3(posicion.X + largo - largo * 10 / 100 - lar * 10 / 100, posicion.Y - alto * 10 / 100, posicion.Z - ancho * 10 / 100), lar * 10 / 100, lar * 10 / 100, alto - alto * 10 / 100));
            partesMesa.Add("pata4", new Cubo(new Vector3(posicion.X + largo - largo * 10 / 100 - lar * 10 / 100, posicion.Y - alto * 10 / 100, posicion.Z - ancho + ancho * 10 / 100 + lar * 10 / 100), lar * 10 / 100, lar * 10 / 100, alto - alto * 10 / 100));
            
        }
        public override void dibujarObjeto()
        {
            foreach (Cubo partes in partesMesa.Values)
            {
                partes.dibujarObjeto();
            }
        }

        public void mover(Vector3 direccion)
        {
            GL.Translate(direccion.X, direccion.Y, direccion.Z);
            dibujarObjeto();
        }

        public void redimencionar(Vector3 escala)
        {
            GL.Scale(escala.X, escala.Y, escala.Z);
            dibujarObjeto();
        }

        public void rotar()
        {
            throw new NotImplementedException();
        }
    }
}
