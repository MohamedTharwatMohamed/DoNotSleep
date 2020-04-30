using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNotSleep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isStop = false;

        private async void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Working!";

            await Task.Run(() =>
            {
                moveTheMouse();
            });
        }

        void moveTheMouse()
        {
            while (!isStop)
            {
                Cursor.Position = new Point(Cursor.Position.X - 5, Cursor.Position.Y - 5);
                Thread.Sleep(5000);
                Cursor.Position = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
            }

        }
       

    }
}
