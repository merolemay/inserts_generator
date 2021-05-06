using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static ArrayList employee;
        private static ArrayList Department;
        private static ArrayList Project;
        private static ArrayList workOn;
        public static void splitmylife()
        {
            employee = new ArrayList();
            Department = new ArrayList();
            Project = new ArrayList();
            workOn = new ArrayList();
            var reader = new StreamReader(File.OpenRead(@"C:\Users\User\RiderProjects\Solution1\ConsoleApplication1\NewDirectory1\Employee.csv"));
            List<string> listA = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var lina2 = line.Split(',');
                    
                 employee.Add("INSERT INTO Employee VALUES(" + lina2[0] + ","+'"'+lina2[1]+'"'+","+'"'+lina2[2]+'"'+","+'"'+lina2[3]+'"'+","+'"'+lina2[4]+'"'+","+"'"+lina2[5]+"'"+","+'"'+lina2[6]+'"'+");");
                 Department.Add("INSERT INTO Department VALUES("+lina2[0]+","+lina2[7]+");");
                 Project.Add("INSERT INTO Project VALUES(" + lina2[0] + "," + lina2[8] + ");");
                 workOn.Add("INSERT INTO workOn VALUES(" + lina2[0] + "," + lina2[0] +","+'"'+lina2[9]+'"'+","+'"'+lina2[10]+'"'+");");
                 
                
            }
            
           
        }
        public static void Main(string[] args)
        {
            splitmylife();
        }
    }
}