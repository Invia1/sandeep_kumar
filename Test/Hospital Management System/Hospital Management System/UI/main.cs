using Hospital_Management_System.models;
using Hospital_Management_System.services;
using System;


namespace Hospital_Management_System.UI
{
     class main
    {
        public static void Main()
        {
            
           
            PatientRegistration obj1 = new PatientRegistration();

            obj1.P_ID = 2;
            obj1.age = 22;
            obj1.aadhar_no = "3567678";
            obj1.FName = "raj";
            obj1.LName = "yadav";
            obj1.specialistDoctor = "dental";
            obj1.address = "noida";
            obj1.gender = "male";
            obj1.Phone_No = "1734787238";

            PatientRegistration obj3 = new PatientRegistration();

            obj3.P_ID = 4;
            obj3.age = 29;
            obj3.aadhar_no = "3567678";
            obj3.FName = "rajni";
            obj3.LName = "paul";
            obj3.specialistDoctor = "dental";
            obj3.address = "kashmir";
            obj3.gender = "female";
            obj3.Phone_No = "1734657238";

            PatientRegistration obj4 = new PatientRegistration();

            obj4.P_ID = 4;
            obj4.age = 29;
            obj4.aadhar_no = "3567678";
            obj4.FName = "rajni";
            obj4.LName = "paul";
            obj4.specialistDoctor = "dental";
            obj4.address = "kashmir";
            obj4.gender = "female";
            obj4.Phone_No = "1734657238";


            PatientRegistration obj2 = new PatientRegistration();

            obj2.P_ID = 3;
            obj2.age = 25;
            obj2.aadhar_no = "392837678";
            obj2.FName = "rajesh";
            obj2.LName = "singh";
            obj2.specialistDoctor = "general medicine";
            obj2.address = "bengal";
            obj2.gender = "male";
            obj2.Phone_No = "985787238";

            patientServices ps=new patientServices();
            
            ps.createData(obj1);
            ps.createData(obj2);
            ps.createData(obj3);
            ps.createData(obj4);
            
            List<PatientRegistration> pList = ps.GetData();
             void alldetails()
            {
                Console.WriteLine("\n");
                foreach (var i in pList)
                {
                    Console.WriteLine("ID :" + i.P_ID);
                    Console.WriteLine("first name:" + i.FName);
                    Console.WriteLine("first name :" + i.LName);
                    Console.WriteLine("age :" + i.age);
                    Console.WriteLine("aadhar number :" + i.aadhar_no);
                    Console.WriteLine("gender :" + i.gender);
                    Console.WriteLine("address :" + i.address);
                    Console.WriteLine("contact number :" + i.Phone_No);
                    Console.WriteLine("visited  :" + i.specialistDoctor);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("/n");

                }
            }

            while(true)
            {
                Console.WriteLine("choose speciality ");
                Console.WriteLine("**************************************************");
                Console.WriteLine("1.Dental ");
                Console.WriteLine("2.orthopedic");
                Console.WriteLine("3.general medicine ");
                Console.WriteLine("4. show all record ");//
                Console.WriteLine("5.update record");
                Console.WriteLine("6. search record ");
                Console.WriteLine("7.Delete record ");
                Console.WriteLine("8.add record ");
                Console.WriteLine("**************************************************");
                Console.WriteLine("\n");
                string a = Console.ReadLine();

                switch (a)

                {
                    case "1":
                        ps.Dental();
                        break;
                    case "2":
                        ps.orthopedic();
                        break;
                    case "3":
                        ps.generalMedicine();
                        break;
                    case "4":
                        alldetails();
                        break;

                    case "5":
                        Console.WriteLine("enter patient id for whom you want to update");
                        int n = int.Parse(Console.ReadLine());

                        ps.UpdateData(n);
                        Console.WriteLine("do you want to see all details");
                        Console.WriteLine("press y or n");
                        string j = Console.ReadLine();
                        if (j == "y")
                        {
                            alldetails();
                        }
                        break;
                        
                    case "6":
                        Console.WriteLine("enter patient id you want to search");
                        int b = int.Parse(Console.ReadLine());

                        ps.Search(b);
                        break;
                    case "7":
                        Console.WriteLine("enter patient id you want to delete");
                        int c = int.Parse(Console.ReadLine());

                        ps.DeleteData(c);
                        break;
                    case "8":
                        PatientRegistration obj = new PatientRegistration();
                        Console.WriteLine("enter patient id");
                        int x = int.Parse(Console.ReadLine());

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
                        string i = Console.ReadLine();

                        obj.P_ID = x;
                        obj.age = y;
                        obj.aadhar_no = z;
                        obj.FName = d;
                        obj.LName = e;
                        obj.specialistDoctor = f;
                        obj.address = g;
                        obj.gender = h;
                        obj.Phone_No = i;

                        ps.createData(obj);
                        Console.WriteLine("1 patient added");
                        Console.WriteLine("do you want to see all details");
                        Console.WriteLine("press y or n");
                        string k= Console.ReadLine();
                        if (k == "y")
                        {
                            alldetails();
                        }
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
                Console.WriteLine("//////////////////////////////////////");
                Console.WriteLine("do you wish to continue");
                Console.WriteLine("press y continue");
                Console.WriteLine("press any key to exit");
                string num1 = Console.ReadLine();
                if (num1 == "y")
                {
                    Main();
                }
                else
                {
                    break;
                }

            } 



        }

    }
}
