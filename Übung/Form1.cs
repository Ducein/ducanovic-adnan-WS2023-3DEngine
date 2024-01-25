using OpenTK.WinForms;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace Übung
{
    public partial class Form1 : Form
    {
        private GLControl MyGLControl;
        public Form1()
        {
            InitializeComponent();
            MyGLControl = new GLControl();


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // You can bind the events here or in the Designer.
            MyGLControl.Resize += MyGLControl_Resize;
            MyGLControl.Paint += MyGLControl_Paint;
        }


        private void MyGLControl_Resize(object? sender, EventArgs e)
        {

        }

        private void MyGLControl_Paint(object? sender, PaintEventArgs e)
        {
            MyGLControl.MakeCurrent();    // Tell OpenGL to draw on MyGLControl.
            GL.Clear(ClearBufferMask.ColorBufferBit);     // Clear any prior drawing.
            GL.ClearColor(Color4.MidnightBlue);
            /*
            ... use various other GL.*() calls here to draw stuff ...
            */

            MyGLControl.SwapBuffers();    // Display the result.
        }

       
    }
}