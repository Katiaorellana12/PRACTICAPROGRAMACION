using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICAPROGRAMACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("idEstudiantes", "CODIGO");
            dataGridView1.Columns.Add("firstName", "NOMBRE");
            dataGridView1.Columns.Add("lastName", "APELLIDO");
            dataGridView1.Columns.Add("age", "EDAD");
            dataGridView1.Columns.Add("nationality", "NACIONALIDAD");

            foreach (var Estudiantes in selectAllData())
            {
                dataGridView1.Rows.Add(Estudiantes.idEstudiantes, Estudiantes.firstName, Estudiantes.lastName, Estudiantes.age, Estudiantes.nationality);
            }
        }

        private static List<Estudiantes> selectAllData()
        {
            //crear la consulta
            List<Estudiantes> result = (
                                    from Estudiantes in Estudiantes.GetEstudiantes()
                                    select new Estudiantes()
                                    {
                                        idEstudiantes = Estudiantes.idEstudiantes,
                                        firstName = Estudiantes.firstName,

                                        lastName = Estudiantes.lastName,
                                        age = Estudiantes.age,
                                        nationality = Estudiantes.nationality
                                    }
                ).ToList();
            //retorna el resultado de la consulta
            return result;
        }
    }

}

