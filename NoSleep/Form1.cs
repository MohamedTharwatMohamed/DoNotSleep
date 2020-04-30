using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoSleep
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
            label2.Text = "Working!";

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
        private void button2_Click(object sender, EventArgs e)
        {
            isStop = true;
            label2.Text = "Stoped!";

        }

    }
}
