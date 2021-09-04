using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFlowAndCollections
{
    class StudentList
    {
        public static void newStudent()
        {
            List<String> students = new List<String>();
            List<Double> grades = new List<Double>();
            String newStudent;
            String input;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    students.Add(input);
                }   
            }
            while (!Equals(newStudent, ""));

            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                input = Console.ReadLine();
                double grade = double.Parse(input);
                grades.Add(grade);
            }

            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
                sum += grades[i];
            }

            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.WriteLine(students.ToArray().ToString());

        }
    }
}
