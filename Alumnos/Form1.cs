using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAlumno.Focus();
            lblCantidadAula.TextAlign = ContentAlignment.MiddleCenter;
            lblCantidadAula.Text = "0";
            lblCantidadLaboratorio.TextAlign = ContentAlignment.MiddleCenter;
            lblCantidadLaboratorio.Text = "0";
            this.AcceptButton = btnAcepta;
        }

        private void btnAcepta_Click(object sender, EventArgs e)
        {
            string texto = txtAlumno.Text.Trim();

            if (texto.Length > 0)
            {
                lsbAula.Items.Add(texto);
                txtAlumno.Text = "";
                txtAlumno.Focus();
                lblCantidadAula.Text = lsbAula.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Digite nombre de alumno");
            }
            txtAlumno.Focus();
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            string seleccionado = "";
            if (lsbAula.SelectedIndex != -1)
            {
                seleccionado = lsbAula.SelectedItem.ToString();
                lsbAula.Items.RemoveAt(lsbAula.SelectedIndex);
                lsbLab.Items.Add(seleccionado);
                lblCantidadAula.Text = lsbAula.Items.Count.ToString();
                lblCantidadLaboratorio.Text = lsbLab.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione elemento en la lista de alumnos del Aula");
            }
        }

        private void btnRetira_Click(object sender, EventArgs e)
        {
            string seleccionado = "";
            if (lsbLab.SelectedIndex != -1)
            {
                seleccionado = lsbLab.SelectedItem.ToString();
                lsbLab.Items.RemoveAt(lsbLab.SelectedIndex);
                lsbAula.Items.Add(seleccionado);
                lblCantidadAula.Text = lsbAula.Items.Count.ToString();
                lblCantidadLaboratorio.Text = lsbLab.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione elemento en la lista de alumnos del Laboratorio");
            }
        }

        private void btnExpulsado_Click(object sender, EventArgs e)
        {
            if (lsbAula.SelectedIndex != -1)
            {
                lsbAula.Items.RemoveAt(lsbAula.SelectedIndex);
                
                lblCantidadAula.Text = lsbAula.Items.Count.ToString();
                lblCantidadLaboratorio.Text = lsbLab.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione elemento de cualquiera de las listas");
            }

            if (lsbLab.SelectedIndex != -1)
            {
                lsbLab.Items.RemoveAt(lsbLab.SelectedIndex);
                lblCantidadAula.Text = lsbAula.Items.Count.ToString();
                lblCantidadLaboratorio.Text = lsbLab.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione elemento de cualquiera de las listas");
            }
        }
    }
}
