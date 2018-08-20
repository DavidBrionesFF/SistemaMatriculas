using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabajo1
{
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void CursosXd_Load(object sender, EventArgs e)
        {

            mostrarInformacion();
        }

        public void mostrarInformacion()
        {
            // TODO: This line of code loads data into the 'cURSOID.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter1.Fill(this.cURSOID.Curso);
            // TODO: This line of code loads data into the 'cursos.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.cursos.Curso);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = "insert into Curso (NomCurso,DuracionMes,observaciones) values (@NomCurso,@DuracionMes,@observaciones)";
            SqlCommand cmd = new SqlCommand(query, Conexion.getInstance().getConextion());

            cmd.Parameters.Add("@NomCurso", textBox1.Text);
            cmd.Parameters.Add("@DuracionMes", textBox2.Text);
            cmd.Parameters.Add("@observaciones", textBox3.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso actualizado correctamente!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = "update Curso set NomCurso=@NomCurso,DuracionMes=@DuracionMes,observaciones=@observaciones where id_curso=@id";
            SqlCommand cmd = new SqlCommand(query, Conexion.getInstance().getConextion());

            cmd.Parameters.Add("@NomCurso", textBox1.Text);
            cmd.Parameters.Add("@DuracionMes", textBox2.Text);
            cmd.Parameters.Add("@observaciones", textBox3.Text);
            cmd.Parameters.Add("@id", comboBox2.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso actualizado correctamente!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarInformacion();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManejadorVistas.getInstance().Menu.Hide();
            ManejadorVistas.getInstance().Sesion.Show();
        }
    }
}
