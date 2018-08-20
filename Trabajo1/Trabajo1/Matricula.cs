using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trabajo1
{
    public partial class Matricula : Form
    {
        public Matricula()
        {
            InitializeComponent();
        }

        private void Matricula_Load(object sender, EventArgs e)
        {
            mostrarInformacion();
        }

        public void mostrarInformacion()
        {
            // TODO: This line of code loads data into the 'escuelaMatriculaDataSet4.Matricula' table. You can move, or remove it, as needed.
            this.matriculaTableAdapter.Fill(this.escuelaMatriculaDataSet4.Matricula);
            // TODO: This line of code loads data into the 'escuelaMatriculaDataSet3.DatosP' table. You can move, or remove it, as needed.
            this.datosPTableAdapter.Fill(this.escuelaMatriculaDataSet3.DatosP);
            // TODO: This line of code loads data into the 'escuelaMatriculaDataSet2.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.escuelaMatriculaDataSet2.Curso);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = "insert into Matricula (año,ObservacionMatricula,alumno,curso) values (@año,@ObservacionMatricula,@alumno,@curso) ";
            SqlCommand cmd = new SqlCommand(query, Conexion.getInstance().getConextion());
            cmd.Parameters.Add("@año",textBox1.Text);
            cmd.Parameters.Add("@ObservacionMatricula", textBox2.Text);
            cmd.Parameters.Add("@alumno", comboBox1.Text);
            cmd.Parameters.Add("@curso", comboBox2.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Matriculado correctamente!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarInformacion();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpiar()
        {
            textBox1.Text = textBox2.Text = "";
        }
    }
}
