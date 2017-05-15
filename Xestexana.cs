using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mashtaga Asylum. Please enter your name: ");
            string patName = Console.ReadLine();
            var pat = new Patient(patName);
            var dep = new Department();
            Console.WriteLine("Our departments are shown below. Please choose one");
            dep.AddDepartments();
            dep.ShowDepartments();
            string chosenDep = Console.ReadLine();
            dep.AddDoctors(chosenDep);
            Console.WriteLine("Doctors of {0} department are shown below. Please select one of them by typin their name: ",chosenDep);
            dep.ShowDoctors();
            var doc = new Doctor();
            Console.ReadLine();
            doc.AddAvailableHours();
            doc.ShowAvailableHours();
            Console.WriteLine("Please type one of the numbers above to book");
            int chosenH = Convert.ToInt32(Console.ReadLine());
            doc.ChooseAvailableHours(chosenH);

            if (Console.ReadKey(true).Key==ConsoleKey.S)
            {
                dep.ShowDepartments();
            }
            if (Console.ReadKey(true).Key == ConsoleKey.H)
            {
                dep.AddAllDoctors();
            }
            // 
            //dep.AddAllDoctors();



        }
    }
    class Department
    {
        
        public string name;
        List<Doctor> doctors = new List<Doctor>();
        List<Doctor> alldoctors = new List<Doctor>();
        List<Doctor> chosenDocs = new List<Doctor>();
        List<Department> departments = new List<Department>();
        
        public void AddDepartments()
        {
            Console.WriteLine("\nAll departments\n");
            departments.Add(new Department("Terapiya"));
            departments.Add(new Department("Kardiologiya"));
            departments.Add(new Department("Travmatologiya"));
            departments.Add(new Department("Cerrahiye"));
            departments.Add(new Department("Pediatriya"));

        }
        public void ShowDepartments()
        {
            foreach (var department in departments)
            {
                Console.WriteLine(department.name);
            }
        }
        
        public void AddDoctors(string chosenDep)
        {

            if (chosenDep == "Terapiya")
            {
                doctors.Add(new Doctor("Lala", "Rustamli"));
                doctors.Add(new Doctor("Kamran", "Memmedli"));



            }
            else if (chosenDep == "Kardiologiya")
            {
                doctors.Add(new Doctor("Harley", "Quinn"));
                doctors.Add(new Doctor("Elovset", "Mellim"));

            }
            else if (chosenDep == "Travmatologiya")
            {
                doctors.Add(new Doctor("Iron", "Man"));
                doctors.Add(new Doctor("Spider", "Man"));

            }
            else if (chosenDep == "Cerrahiye")
            {
                doctors.Add(new Doctor("Green", "Mom"));
                doctors.Add(new Doctor("Black", "Hole"));

            }
            else if (chosenDep == "Pediatriya")
            {
                doctors.Add(new Doctor("Sheldo", "Cooper"));
                doctors.Add(new Doctor("Ron", "Winsley"));

            }
            else
            {
                Console.WriteLine("Error verdim");
            }

        }
        public void ShowDoctors()
        {
            foreach (var doc in doctors)
            {
                Console.WriteLine(doc.name +" " + doc.surname);
            }
        }

        public void AddAllDoctors()
        {
            alldoctors.Add(new Doctor("Lala", "Rustamli"));
            alldoctors.Add(new Doctor("Kamran", "Memmedli"));
            alldoctors.Add(new Doctor("Harley", "Quinn"));
            alldoctors.Add(new Doctor("Elovset", "Mellim"));
            alldoctors.Add(new Doctor("Iron", "Man"));
            alldoctors.Add(new Doctor("Spider", "Man"));
            alldoctors.Add(new Doctor("Green", "Mom"));
            alldoctors.Add(new Doctor("Black", "Hole"));
            alldoctors.Add(new Doctor("Sheldo", "Cooper"));
            alldoctors.Add(new Doctor("Ron", "Winsley"));
            Console.WriteLine("\nAll doctors\n");
            foreach (var doc in alldoctors)
            {
                Console.WriteLine(doc.name + " " + doc.surname);
            }
        }
       
        public Department(string name)
        {
            this.name = name;
        }
        public Department()
        {
            
        }
        public Department(string name,List<Doctor>doctors)
        {
            this.name = name;
            this.doctors = doctors;
        }
    }
    class Doctor
    {
        public string name;
        public string surname;
        List<string> availableHours = new List<string>();
        public Doctor()
        {

        }
        
        public Doctor(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            
        }
        public void AddAvailableHours()
        {
            availableHours.Add("08: 00 - 10: 00 Dolu");
            availableHours.Add("10: 00 - 12: 00 Bos");
            availableHours.Add("12: 00 - 14: 00 Bos");
            availableHours.Add("14: 00 - 16: 00 Dolu");
            availableHours.Add("16: 00 - 18: 00 Dolu");
            
        }
        public void ShowAvailableHours()
        {
            for (int i = 0; i < availableHours.Count; i++)
            {
                Console.WriteLine((i+1)+ ") " + availableHours[i]);
            }
        }
        public void ChooseAvailableHours(int chosenH)
        {
            for(int i =0;i<availableHours.Count;i++)
            {
                if (chosenH - 1 == i)
                {
                    if (availableHours[i].Contains("Dolu"))
                    {
                        Console.WriteLine("Don't select unavailable hours");
                    }
                    else
                    {
                        availableHours[i] = availableHours[i].Replace("Bos", "Dolu");
                        
                    }
                }
                Console.WriteLine((i + 1) + ") " + availableHours[i]);
            }
        }
    }
    class Patient
    {
        string name;
        public Patient(string name)
        {
            this.name = name;
        }
    }
}
