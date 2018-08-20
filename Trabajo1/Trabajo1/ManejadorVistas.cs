using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo1.vista_reportes;

namespace Trabajo1
{
    class ManejadorVistas
    {
        private static ManejadorVistas instance = new ManejadorVistas();
        private Alumno alumno = new Alumno();
        private Matricula matricula = new Matricula();
        private Curso curso = new Curso();
        private IniciarSesion sesion = new IniciarSesion();
        private Menu menu = new Menu();

        public AlumnosReporte reporteAlumno = new AlumnosReporte();

        public Alumno Alumno
        {
            get
            {
                return alumno;
            }

            set
            {
                alumno = value;
            }
        }

        public Matricula Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public Curso Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }
        

        public IniciarSesion Sesion
        {
            get
            {
                return sesion;
            }

            set
            {
                sesion = value;
            }
        }

        public Menu Menu
        {
            get
            {
                return menu;
            }

            set
            {
                menu = value;
            }
        }

        private ManejadorVistas()
        {

        }


        public static ManejadorVistas getInstance()
        {
            return instance;
        }
    }
}
