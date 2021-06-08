using System;
using System.Collections.Generic;
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
    
    class Cubo: Objeto
    {
        private Vector3 pos;
        private float ancho;
        private float largo;
        private float alto;
        public Cubo(Vector3 posicion , float ancho, float largo, float alto)
        {
            

            this.pos = posicion;
            this.ancho = ancho;
            this.largo = largo;
            this.alto = alto;

        }
        public override void dibujarObjeto()
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(188 / 255.0f, 129 / 255.0f, 80 / 255.0f);
            //Cara Frontal
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);

            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);
            //Cara de Atras
           // GL.Color3(0.0, 1.0, 0.0);

            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);

            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z - ancho);
            //cara izquierda

           // GL.Color3(0.0, 0.0, 1.0);
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);

            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            //cara derecha
            //GL.Color3(1.0, 1.0, 0.0);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);

            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z - ancho);
            //cara superior
            //GL.Color3(0.0, 1.0, 1.0);
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);

            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);
            //cara inferior
           // GL.Color3(1.0, 0.0, 1.0);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);

            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z - ancho);

            GL.End();

        }
    }
}
