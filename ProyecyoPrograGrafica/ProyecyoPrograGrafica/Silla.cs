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
    class Silla : Objeto, IObjeto 
    {
        protected float ancho;
        protected float alto;
        protected float largo;
        protected Vector3 pos;
        private Hashtable partesSilla;
        public Silla(Vector3 posicion, float ancho, float alto, float largo)
        {
            this.pos = posicion;
            this.ancho = ancho;
            this.alto = alto;
            this.largo = largo;

            float lar;
            if (this.ancho > this.largo)
            {
                lar = ancho;
            }
            else
            {
                lar = largo;
            }
            //-------------------------partes de la Silla relativo--------------------------------

            partesSilla = new Hashtable();
            partesSilla.Add("asiento", new Cubo(pos, ancho, largo, alto * 5 / 100));
            partesSilla.Add("espaldar", new Cubo(new Vector3(pos.X, pos.Y, pos.Z - ancho + ancho * 10 / 100), ancho * 10 / 100, largo, -alto * 50 / 100));
            partesSilla.Add("pata1", new Cubo(new Vector3(pos.X + largo * 10 / 100, pos.Y - alto * 5 / 100, pos.Z - ancho * 10 / 100), lar * 15 / 100, lar * 15 / 100, alto * 45 / 100 - alto * 5 / 100));
            partesSilla.Add("pata2", new Cubo(new Vector3(pos.X + largo * 10 / 100, pos.Y - alto * 5 / 100, pos.Z - ancho + ancho * 10 / 100 + lar * 15 / 100), lar * 15 / 100, lar * 15 / 100, alto * 45 / 100 - alto * 5 / 100));
            partesSilla.Add("pata3", new Cubo(new Vector3(pos.X + largo - largo * 10 / 100 - lar * 15 / 100, pos.Y - alto * 5 / 100, pos.Z - ancho * 10 / 100), lar * 15 / 100, lar * 15 / 100, alto * 45 / 100 - alto * 5 / 100));
            partesSilla.Add("pata4", new Cubo(new Vector3(pos.X + largo - largo * 10 / 100 - lar * 15 / 100, pos.Y - alto * 5 / 100, pos.Z - ancho + ancho * 10 / 100 + lar * 15 / 100), lar * 15 / 100, lar * 15 / 100, alto * 45 / 100 - alto * 5 / 100));

        }
        public override void dibujarObjeto()
        {
            foreach (Cubo partes in partesSilla.Values)
            {
                partes.dibujarObjeto();
            }
        }

        public void rotar()
        {
            
        }
        public void redimencionar(Vector3 escala)
        {
            GL.Scale(escala.X,escala.Y,escala.Z);
            dibujarObjeto();
        }

        public void mover(Vector3 direccion)
        {
            GL.Translate(direccion.X, direccion.Y, direccion.Z);
            dibujarObjeto();
        }

       
    }
}
