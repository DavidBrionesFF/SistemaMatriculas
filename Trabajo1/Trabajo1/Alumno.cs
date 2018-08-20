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
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }

        private void mostrarInformacion()
        {
            // TODO: This line of code loads data into the 'escuelaMatriculaDataSet1.DatosP' table. You can move, or remove it, as needed.
            this.datosPTableAdapter1.Fill(this.escuelaMatriculaDataSet1.DatosP);
            // TODO: This line of code loads data into the 'escuelaMatriculaDataSet.DatosP' table. You can move, or remove it, as needed.
            this.datosPTableAdapter.Fill(this.escuelaMatriculaDataSet.DatosP);
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            mostrarInformacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = "insert into DatosP (nombre, apellido, sexo, edad, NomPadre, NomMadre, Telefono, Celular, Email, Obseraciones ) ";
            query = query + "values (@nombre, @apellido, @sexo, @edad, @NomPadre, @NomMadre, @Telefono, @Celular, @Email, @Obseraciones ) ";
            
            SqlCommand cmd = new SqlCommand(query, Conexion.getInstance().getConextion());

            cmd.Parameters.Add("@nombre", textBox1.Text);
            cmd.Parameters.Add("@apellido", textBox2.Text);
            cmd.Parameters.Add("@sexo", radioButton1.Checked);
            cmd.Parameters.Add("@edad", textBox3.Text);
            cmd.Parameters.Add("@NomPadre", textBox5.Text);
            cmd.Parameters.Add("@NomMadre", textBox4.Text);
            cmd.Parameters.Add("@Telefono", textBox6.Text);
            cmd.Parameters.Add("@Celular", textBox7.Text);
            cmd.Parameters.Add("@Email", textBox8.Text);
            cmd.Parameters.Add("@Obseraciones", textBox9.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado correctamente!!","Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarInformacion();
                limpiar();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpiar()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = "update DatosP set nombre=@nombre, apellido=@apellido, sexo=@sexo, edad=@edad, NomPadre=@NomPadre, NomMadre=@NomMadre, Telefono=@Telefono, Celular=@Celular, Email=@Email, Obseraciones=@Obseraciones where id_datosP=@id ";

            SqlCommand cmd = new SqlCommand(query, Conexion.getInstance().getConextion());

            cmd.Parameters.Add("@nombre", textBox1.Text);
            cmd.Parameters.Add("@apellido", textBox2.Text);
            cmd.Parameters.Add("@sexo", radioButton1.Checked);
            cmd.Parameters.Add("@edad", textBox3.Text);
            cmd.Parameters.Add("@NomPadre", textBox5.Text);
            cmd.Parameters.Add("@NomMadre", textBox4.Text);
            cmd.Parameters.Add("@Telefono", textBox6.Text);
            cmd.Parameters.Add("@Celular", textBox7.Text);
            cmd.Parameters.Add("@Email", textBox8.Text);
            cmd.Parameters.Add("@Obseraciones", textBox9.Text);
            cmd.Parameters.Add("@id", comboBox2.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado correctamente!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarInformacion();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var query = "delete from DatosP where id_datosP=@id ";

            SqlCommand cmd = new SqlCommand(query, Conexion.getInstance().getConextion());
            
            cmd.Parameters.Add("@id", comboBox2.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarInformacion();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            ManejadorVistas.getInstance().Menu.Hide();
            ManejadorVistas.getInstance().Sesion.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManejadorVistas.getInstance().reporteAlumno.Show();
        }
        
    }
}
