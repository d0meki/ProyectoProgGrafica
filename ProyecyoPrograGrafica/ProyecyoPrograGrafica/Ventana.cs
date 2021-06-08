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
using System.Collections;
namespace ProyecyoPrograGrafica
{
    class Ventana
    {
        GameWindow ventana;
        Escenario esc = new Escenario();
        public Ventana(GameWindow ventana)
        {
            this.ventana = ventana;
            comenzar();
        }
        void comenzar()
        {
            ventana.Load += cargar;
            ventana.Resize += redimencionar;
            ventana.RenderFrame += renderizar;
            ventana.Run(1.0 / 60.0);
        }
        void redimencionar(object ob, EventArgs e)
        {
            GL.Viewport(0, 0, ventana.Width, ventana.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(100), ventana.Width / ventana.Height, 1.0f, 100.0f);
            GL.LoadMatrix(ref matrix);
            GL.MatrixMode(MatrixMode.Modelview);

        }
        void renderizar(object o, EventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            esc.dibujarEscenario();//dibujamos escenario

            ventana.SwapBuffers();
        }
        void cargar(object o, EventArgs e)
        {
            //cargamos los objetos al escenario
            esc.agregarDibujo("chair", new Silla(new Vector3(-1.5f, 0.15f, -0.7f), 0.4f, 1f, 0.50f));
            esc.agregarDibujo("cube", new Cubo(new Vector3(-90.0f, 0.0f, -40.0f), 5, 10, 10));
            esc.agregarDibujo("table", new Mesa(new Vector3(-0.5f, 0.4f, 0f), 1.5f, 0.8f, 2f));

            GL.ClearColor(65 / 255.0f, 137 / 255.0f, 157 / 255.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }

    }
}
