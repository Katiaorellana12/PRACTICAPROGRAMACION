using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAPROGRAMACION
{
    class Estudiantes
    {



        public int idEstudiantes { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }


        public static List<Estudiantes> GetEstudiantes()
        {
            List<Estudiantes> students = new List<Estudiantes>
            {
                new Estudiantes{ idEstudiantes= 1001, firstName= "Grecia", lastName="Calderon", age=25 , nationality="Chilena" },
                new Estudiantes{ idEstudiantes= 1002, firstName= "Rocio", lastName="Orellana", age=17 , nationality="Argentina" },
                new Estudiantes{ idEstudiantes= 1003, firstName= "Jason", lastName="Gomez", age=23 , nationality="Canadiense"},
                new Estudiantes{ idEstudiantes= 1004, firstName= "Erick", lastName="Cano", age=16 , nationality="Mexicano" },
                new Estudiantes{ idEstudiantes= 1005, firstName= "Ismael",lastName="Luna", age=19 , nationality="Guatemalteco" },
                new Estudiantes{ idEstudiantes= 1006, firstName= "Ariel", lastName="Reyes", age=17 , nationality="Salvadoreño" },
                new Estudiantes{ idEstudiantes= 1007, firstName= "Melvin", lastName="Hernandez", age=21 , nationality="Portugueño" },
            };
            return students;
        }


    }
}







