using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Trabajo1
{
    public partial class Menu : Form
    {
        private bool maxi = false;
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 55)
            {
                MenuVertical.Width = 200;
            }
            else
            {
                MenuVertical.Width = 55;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (maxi)
            {
                this.WindowState = FormWindowState.Normal;
                maxi = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                maxi = true;

            }
        }

        private void abrirVentanPane(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirVentanPane(ManejadorVistas.getInstance().Alumno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirVentanPane(ManejadorVistas.getInstance().Curso);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirVentanPane(ManejadorVistas.getInstance().Matricula);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManejadorVistas.getInstance().Menu.Hide();
            ManejadorVistas.getInstance().Sesion.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            abrirVentanPane(ManejadorVistas.getInstance().Alumno);
        }
    }
}
