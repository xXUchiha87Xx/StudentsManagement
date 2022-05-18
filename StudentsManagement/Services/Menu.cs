using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsManagement.Services
{
    class Menu
    {
        public static string Header(string header)
        {
            string format = string.Format("----------------{0}----------------", header);
            Console.Title = header;
            return format;
        }
        public static void Show()
        {
            bool Condicion = false;
            string Opc = string.Empty;
            do
            {
                do
                {
                    if (Condicion)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcion Incorrecta!!!");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Header("Registro Escuela");
                    Console.WriteLine("Seleccione una opcion: ");
                    Console.WriteLine("1- Registrar Estudiante.\n2- Registrar Asignatura.\n3- Inscribir Estudiante en Asignatura.\n4- Evaluar Estudiantes por Asignaturas.\n5- Evaluar Asignaturas por Estudiantes.\n6- Visualizar Notas por Asignaturas.\n7- Visualizar Notas por Estudiante.\n8- Visualizar Estudiantes.\n9- Visualizar Asignaturas\n10- Salir.");
                    Opc = Console.ReadLine();
                    Condicion = true;
                } while (Opc != "1" && Opc != "2" && Opc != "3" && Opc != "4" && Opc != "5" && Opc != "6" && Opc != "7" && Opc != "8" && Opc != "9" && Opc != "10");

                switch (Opc)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        AddSubject();
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":
                        DisplayStudents();
                        break;
                    case "9":

                        break;
                    case "10":

                        break;
                }

                if (Opc == "0")
                {
                    Console.WriteLine("Saliendo...");
                    Console.ReadKey();
                }

                Condicion = false;

            } while (Opc != "10");

        }
        public static void AddStudent()//Agregar Estudiante
        {
            Console.Clear();
            Header("Agregar Estudiante");
            Services.Student.Add();
        }

        public static void AddSubject()//Agregar Materia
        {

        }

        public static void EnrollStudentInSubject()//Inscribir Estudiante En Asignatura
        {

        }

        public static void AssessStudentBySubject()//Evaluar Estudiante por Asignatura
        {

        }

        public static void AssessSubjectByStudents()//Evaluar Asignaturas por Estudiantes
        {

        }

        public static void ViewGradesBySubjects()//Visualizar Notas por Asignaturas
        {

        }

        public static void ViewGradesByStudents()//Visualizar Notas por Estudiantes
        {

        }

        public static void DisplayStudents()//Visualizar Estudiantes
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Header("Vizualizar Estudiantes");
            Services.Student.GetAll();
        }

        public static void DisplaySubjects()//Visualizar Materias
        {
            
        }
    }
}
