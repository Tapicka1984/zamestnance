using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Osoba osoba;
        private void button1_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1.Text;
            string prijmeni = textBox2.Text;
            double HodinovaMzda = double.Parse(textBox3.Text);
            osoba = new Osoba(jmeno, prijmeni, HodinovaMzda);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBox4.Text);
            switch(cislo)
            {
                case 1:
                    {
                        MessageBox.Show(osoba.pocet_dni());
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        MessageBox.Show("spatne cislo more");
                        break;
                    }
            }
        }
    }
}
