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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "" && textBox2.Text == ""))
            {
                String query = "select id_usuario from Usuarios where Nombre=@nombre and Clave=@clave";
                SqlCommand cmd = new SqlCommand(query, Conexion.getInstance().getConextion());
                cmd.Parameters.Add("@nombre", textBox1.Text);
                cmd.Parameters.Add("@clave", textBox2.Text);

                try
                {
                    int num = Convert.ToInt32(cmd.ExecuteScalar());

                    if (num == 0)
                    {
                        MessageBox.Show("Error de usuario y contraseña","Error!!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Hide();
                        ManejadorVistas.getInstance().Menu.Show();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {

            }

            
        }
    }
}
