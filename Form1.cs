using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            pole = new double[textBox1.Lines.Length];
            UlozitDoPole(pole, textBox1);

        }
        static private void UlozitDoPole(double[] pole,TextBox textBox)
        {
            for(int i = 0; i < textBox.Lines.Length; i++)
            {
                pole[i] = int.Parse(textBox.Lines[i]);
            }
        }
        static private void ZobrazitPole(double[] pole, ListBox listbox)
        {
            foreach(double x in pole)
            {
                listbox.Items.Add(x);
            }
        }
        static private bool JeRostouci(double[] pole)
        {
            bool jeRostouci = true;
            for (int i = 0; i < pole.Length-1; i++)
            {
                if (pole[i] >= pole[i+1]) jeRostouci = false;
            }
            return jeRostouci;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZobrazitPole(pole, listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (JeRostouci(pole)) MessageBox.Show("Pole je rostoucí");
            else MessageBox.Show("Neroste");

        }
    }
}
