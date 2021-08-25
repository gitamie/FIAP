using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at2tri11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;

            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            if (altura >= 4.00 && altura <= 4.50)
            {
                MessageBox.Show("Você pode passar pela ponte A");
            }

            else
            {
                MessageBox.Show("Você ultrapassou a altura permitida e não pode passar pela ponte A");
            }

            if (altura >= 3.00 && altura <= 3.50)
            {
                MessageBox.Show("Você pode passar pela ponte B");
            }

            else
            {
                MessageBox.Show("Você ultrapassou a altura permitida e não pode passar pela ponte B");
            }

            if (altura >= 5.00 && altura <= 5.50)
            {
                MessageBox.Show("Você pode passar pela ponte C");
            }

            else
            {
                MessageBox.Show("Você ultrapassou a altura permitida e não pode passar pela ponte C");


                if (peso >= 300 && peso <= 350)
                {
                    MessageBox.Show("Você pode passar pela ponte A");
                }

                else
                {
                    MessageBox.Show("Você ultrapassou o peso permitido e não pode passar pela ponte A");
                }

                if (peso >= 400 && peso <= 450)
                {
                    MessageBox.Show("Você pode passar pela ponte B");
                }

                else
                {
                    MessageBox.Show("Você ultrapassou o peso permitido e não pode passar pela ponte B");
                }

                if (peso >= 500 && peso <= 550)
                {
                    MessageBox.Show("Você pode passar pela ponte C");
                }

                else
                {
                    MessageBox.Show("Você ultrapassou o peso permitido e não pode passar pela ponte C");


                }






            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click_1(object sender, EventArgs e)
        {
            double peso, altura;

            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            if (altura >= 4.00 && altura <= 4.50)
            {
                MessageBox.Show("Você pode passar pela ponte A");
            }

            else
            {
                MessageBox.Show("Você ultrapassou a altura permitida e não pode passar pela ponte A");
            }

            if (altura >= 3.00 && altura <= 3.50)
            {
                MessageBox.Show("Você pode passar pela ponte B");
            }

            else
            {
                MessageBox.Show("Você ultrapassou a altura permitida e não pode passar pela ponte B");
            }

            if (altura >= 5.00 && altura <= 5.50)
            {
                MessageBox.Show("Você pode passar pela ponte C");
            }

            else
            {
                MessageBox.Show("Você ultrapassou a altura permitida e não pode passar pela ponte C");


                if (peso >= 300 && peso <= 350)
                {
                    MessageBox.Show("Você pode passar pela ponte A");
                }

                else
                {
                    MessageBox.Show("Você ultrapassou o peso permitido e não pode passar pela ponte A");
                }

                if (peso >= 400 && peso <= 450)
                {
                    MessageBox.Show("Você pode passar pela ponte B");
                }

                else
                {
                    MessageBox.Show("Você ultrapassou o peso permitido e não pode passar pela ponte B");
                }

                if (peso >= 500 && peso <= 550)
                {
                    MessageBox.Show("Você pode passar pela ponte C");
                }

                else
                {
                    MessageBox.Show("Você ultrapassou o peso permitido e não pode passar pela ponte C");


                }
            }
        }
    }
}

    