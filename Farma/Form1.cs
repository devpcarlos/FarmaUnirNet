using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            if (text1 == "")
            {
                MessageBox.Show("Por favor ingrese un dato el campo esta vacio");
                return;
            };

            if (text2 == "")
            {
                MessageBox.Show("Por favor ingrese un dato el campo esta vacio");
                return;
            };

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione una opcion");
                return;
            };

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Por favor selecione un distribuidor");
                return;
            };

            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Por favor selecione unA Sucursal");
                return;
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedItem = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
