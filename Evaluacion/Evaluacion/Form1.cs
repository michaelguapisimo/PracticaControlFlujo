using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form   
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (estudiantes.Count > 0) 
            {
                double promedio = estudiantes.Average(est => est.Nota);
                MessageBox.Show($"El promedio es: {promedio}");

                var top3 = estudiantes.OrderByDescending(est => est.Nota).Take(3).ToList();
                string resultado = "Top 3 estudiantes:\n";
                for (int i = 0; i < top3.Count; i++)
                {
                    resultado += $"{i + 1}. {top3[i].Nombre} - Nota: {top3[i].Nota}\n";
                }
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("No hay estudiantes registrados.");
            }
        }

        List<Estudiante> estudiantes = new List<Estudiante>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            double nota;
            if (double.TryParse(tbNota.Text, out nota) && nota >= 0 &&  nota <= 100)
            {
                if (estudiantes.Count < 1000)
                {
                    Estudiante estudiante = new Estudiante(nombre, nota);
                    estudiantes.Add(estudiante);
                    lstEstudiantes.Items.Add($"{nombre} - Nota: {nota}");
                }
                else
                {
                    MessageBox.Show("Se ha alcanzado el límite de 1000 estudiantes.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una nota válida entre 0 y 100.");
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
