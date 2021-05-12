using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace InsertsGenerator
{
    public class insertsGenerator
    {
        private static ArrayList employee;
        private static ArrayList Department;
        private static ArrayList Project;
        private static ArrayList workOn;
        public static void Splitmylife()
        {
            employee = new ArrayList();
            Department = new ArrayList();
            Project = new ArrayList();
            workOn = new ArrayList();

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\data\\DataSet.csv";
            var reader = new StreamReader(File.OpenRead(path));
            List<string> listA = new List<string>();
            while (!reader.EndOfStream)
            {
               
                var line = reader.ReadLine();
                var lina2 = line.Split(',');

                employee.Add("INSERT INTO Employee VALUES("+"'"+ lina2[0]+"'"+ "," + "'" + lina2[1] + "'" + "," + "'" + lina2[2] + "'" + "," + "'" + lina2[3] + "'" + "," + "'" + lina2[4] + "'" + "," + "'" + lina2[5] + "'" + "," +"'"+ lina2[6]+"'"+");");
                Department.Add("INSERT INTO Department VALUES("+"'"+ lina2[0]+"'"+ ","+ "'"+ lina2[7]+ "'" + ");");
                Project.Add("INSERT INTO Projectt VALUES("+"'"+ lina2[11] +"'"+  "," + "'"+ lina2[8] + "'"+ ");");
                workOn.Add("INSERT INTO WorksOn VALUES(" +"'"+  lina2[0] +"'"+  "," +"'"+  lina2[11] + "'"+ "," + "'" + lina2[9] + "'" + "," + "'" + lina2[10] + "'" + ");");
          
            }
            employee.RemoveAt(0);
            Department.RemoveAt(0);
            Project.RemoveAt(0);
            workOn.RemoveAt(0);
            reader.Close();

        }
        public static void Main(string[] args)
        {
            DelectContent();
            Splitmylife();
            GenerateInserts();
           
            
        }


        public static void DelectContent()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\data\\inserts.txt";
            File.WriteAllText(path, String.Empty);

        }

        public static void GenerateInserts()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\data\\inserts.txt";
            var writer = new StreamWriter(path);

            foreach (var item in employee)
            {
                writer.WriteLine(item);

            }
            foreach (var item in Department)
            {
                writer.WriteLine(item);

            }
            foreach (var item in Project)
            {
                writer.WriteLine(item);

            }
            foreach (var item in workOn)
            {
                writer.WriteLine(item);

            }
            writer.Close();
        }

        
    }
}

