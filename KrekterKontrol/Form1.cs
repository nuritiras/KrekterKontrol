using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrekterKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //picturebox'a x ve y koordinatları atıyoruz.
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right && x>0)
                x += 5;//Tuşa 1 kere basıldığında kaç pixel kayacağını gösteriyor
            if (e.KeyCode == Keys.Left && x>0)
                x -= 5;//Tuşa 1 kere basıldığında kaç pixel kayacağını gösteriyor
            else if (e.KeyCode == Keys.Up && y > 0)
                y -= 5;
            else if (e.KeyCode == Keys.Down && y < 410)
                y += 5;
            pictureBox1.Location = new Point(x, y);

            if (x < 100 && y < 100)// Nesne sol üste gidince işlem yapılsın diye.
            {
                MessageBox.Show("Tebriklern:");
                pictureBox1.Location = new Point(250, 250);//Sol üste gidince tekrar başlıyacağı yer.
            }
        }
    }
}
