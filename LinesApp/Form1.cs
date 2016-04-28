using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinesApp
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black);
        Graphics gr = null;

        static int center_x, center_y;
        static int start_x, start_y;
        static int end_x, end_y;

        static int my_angle = 0;
        static int my_length = 0;
        static int my_increment = 0;
        static int num_lines = 0;

        public Form1()
        {
            InitializeComponent();
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            myPen.Width = 1;
            my_length = Int32.Parse(length.Text);
            gr = canvas.CreateGraphics();
            for (int i = 0; i < Int32.Parse(number_of_lines.Text); i++)
                drawLine();
        }

        private void drawLine()
        {
            Random randomGen = new Random();
            myPen.Color = Color.FromArgb(randomGen.Next(255), randomGen.Next(255), randomGen.Next(255));

            my_angle = my_angle + Int32.Parse(angle.Text);
            my_length = my_length + Int32.Parse(increment.Text);

            end_x = (int)(start_x + Math.Cos(my_angle * .017453292519) * my_length);
            end_y = (int)(start_y + Math.Sin(my_angle * .017453292519) * my_length);

            Point[] points = 
            {
                new Point(start_x, start_y),
                new Point(end_x, end_y)
            };

            start_x = end_x;
            start_y = end_y;

            gr.DrawLines(myPen, points);
        }
        private void go_btn_Click(object sender, EventArgs e)
        {
            my_length = Int32.Parse(length.Text);
            my_increment = Int32.Parse(increment.Text);
            my_angle = Int32.Parse(angle.Text);

            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;

            canvas.Refresh();
        }

		private void butExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
    }
}
