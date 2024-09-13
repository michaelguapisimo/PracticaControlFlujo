using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Form1 : Form
    {
        
        private List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = tbNombres.Text.Trim();
            string apellidos = tbApellidos.Text.Trim();
            DateTime fechaNacimiento;

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos))
            {
                MessageBox.Show("Por favor, ingrese nombres y apellidos.");
                return;
            }

            if (!DateTime.TryParseExact(tbFechaNacimiento.Text.Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida en formato dd/MM/yyyy.");
                return;
           
            }
            Persona nuevaPersona = new Persona
            {
                Nombres = nombres,
                Apellidos = apellidos,
                FechaNacimiento = fechaNacimiento
            };

            personas.Add(nuevaPersona);

            // Actualizar la lista
            ActualizarLista();

        }
        private void ActualizarLista()
        {
            lstPersonas.Items.Clear();
            foreach (var persona in personas)
            {
                lstPersonas.Items.Add(persona.ToString());
            }
        }


    }
}
