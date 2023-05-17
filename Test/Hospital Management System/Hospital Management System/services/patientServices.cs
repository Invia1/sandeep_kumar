using System;
using System.Collections.Generic;
using Hospital_Management_System.functionalities;
using Hospital_Management_System.models;


namespace Hospital_Management_System.services
{
  
    public  class patientServices : Ipatient

    {
        List<PatientRegistration> patientList = new List<PatientRegistration>();
        public int createData(PatientRegistration p)
        {
            patientList.Add(p);
            return 1 ;
        }

        public List<PatientRegistration> GetData()
        {
            return patientList;
        }

        public void UpdateData(int n)
        {
            int a = 0;
            foreach (PatientRegistration i in patientList)
            {
                if (i.P_ID == n)
                {
                    

                    Console.WriteLine("enter your age");
                    int y = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter your aadhar number");
                    string z = Console.ReadLine();

                    Console.WriteLine("enter your first name");
                    string d = Console.ReadLine();

                    Console.WriteLine("enter your last name");
                    string e = Console.ReadLine();

                    Console.WriteLine("enter which specialist you want to meet");
                    string f = Console.ReadLine();

                    Console.WriteLine("enter your address");
                    string g = Console.ReadLine();

                    Console.WriteLine("enter your gender");
                    string h = Console.ReadLine();

                    Console.WriteLine("enter your phone number");
                    string k = Console.ReadLine();

                   
                    i.age = y;
                    i.aadhar_no = z;
                    i.FName = d;
                    i.LName = e;
                    i.specialistDoctor = f;
                    i.address = g;
                    i.gender = h;
                    i.Phone_No = k;

                    Console.WriteLine("1 record updated");
                    a++;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine(" detail doesn't exist ");
            }

        }






        public void DeleteData(int n)
        {
            int a = 0;
            foreach (PatientRegistration i in patientList)
            {
                if (i.P_ID == n)
                {

                    patientList.Remove(i);
                    Console.WriteLine(" 1 record deleted ");
                    a++;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine(" detail doesn't exist ");
            }

        }





        public void Search(int n)
        {
            int a = 0;
            foreach (PatientRegistration i in patientList)
            {
                if (i.P_ID == n)
                {

                    Console.WriteLine("record found");

                    a++;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine(" record  not found ");
            }

        }


        public void Dental()
        {
            Console.WriteLine("enter your name");
            string s= Console.ReadLine();
            Console.WriteLine("enter appointment day");
            
            string r = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------******--------------------------");
            Console.WriteLine($"hello {s} your appointment day for dental checkup is {r} ");
            Console.WriteLine("thank you");
            Console.WriteLine("--------------------------******--------------------------");
        }

        public void orthopedic()
        {
            Console.WriteLine("enter your name");
            string s = Console.ReadLine();
            Console.WriteLine("enter appointment day");

            string r = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------******--------------------------");
            Console.WriteLine($"hello {s} your appointment day for orthopedic problem is {r} ");
            Console.WriteLine("thank you");
            Console.WriteLine("--------------------------******--------------------------");

        }

        public void generalMedicine()
        {
            Console.WriteLine("enter your name");
            string s = Console.ReadLine();
            Console.WriteLine("enter appointment day");

            string r = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------******--------------------------");
            Console.WriteLine($"hello {s} your appointment day in general medicine  is {r} ");
            Console.WriteLine("thank you");
            Console.WriteLine("--------------------------******--------------------------");

        }

    }
}
