using Hospital_Management_System.functionality;
using Hospital_Management_System.model;
using Hospital_Management_System.service;
using System;


namespace Hospital_Management_System.UI
{
    class main
    {
        public static void Main()
        {

            patientRegistration obj1 = new patientRegistration();
            obj1.P_Id = 1;
            obj1.F_Name = "sandeep";
            obj1.L_Name = "kumar";
            obj1.gender = "male";
            obj1.aadharNo = "123456789098";
            obj1.address = "delhi";
            obj1.age = 22;
            obj1.speciaist = "orthopedic";
            obj1.phoneNo = "7545155445";



            patientRegistration obj2 = new patientRegistration();
            obj2.P_Id = 2;
            obj2.F_Name = "raju";
            obj2.L_Name = "kumar";
            obj2.gender = "male";
            obj2.aadharNo = "345678129056";
            obj2.address = "kashmir";
            obj2.age = 29;
            obj2.speciaist = "dental";
            obj2.phoneNo = "7874465690";


            patientRegistration obj3 = new patientRegistration();
            obj3.P_Id = 3;
            obj3.F_Name = "rajnis";
            obj3.L_Name = "kumari";
            obj3.gender = "female";
            obj3.aadharNo = "567890432135";
            obj3.address = "noida";
            obj3.age = 29;
            obj3.speciaist = "general medicice";
            obj3.phoneNo = "7545155445";


            patientRegistration obj4 = new patientRegistration();
            obj4.P_Id = 4;
            obj4.F_Name = "san";
            obj4.L_Name = "kumar";
            obj4.gender = "male";
            obj4.aadharNo = "987684113456";
            obj4.address = "bihar";
            obj4.age = 25;
            obj4.speciaist = "orthopedic";
            obj4.phoneNo = "7545687445";

            Ipatient ps = new patientService();
            ps.createData(obj1);
            ps.createData(obj2);
            ps.createData(obj3);
            ps.createData(obj4);

            IEnumerable<patientRegistration> PL = ps.GetData();
            void alldetails()
            {
                foreach (var i in PL)
                {
                    Console.WriteLine("ID         :  " + i.P_Id);
                    Console.WriteLine("First name :  " + i.F_Name);
                    Console.WriteLine("last name  :  " + i.L_Name);
                    Console.WriteLine("gender     :  " + i.gender);
                    Console.WriteLine("age        :  " + i.age);
                    Console.WriteLine("aadhar id  :  " + i.aadharNo);
                    Console.WriteLine("address    :  " + i.address);
                    Console.WriteLine("phone number: " + i.phoneNo);
                    Console.WriteLine("specialist : " + i.speciaist);
                    Console.WriteLine("--------------------------------------------------");


                }
            }
            Console.WriteLine("****************************************************");

            Console.WriteLine("enter your choice");


            Console.WriteLine("1.book appointment");

            Console.WriteLine("2.update record");
            Console.WriteLine("3.delete record");
            Console.WriteLine("4.search");
            Console.WriteLine("5.add patient");
            Console.WriteLine("6.all details");
            Console.WriteLine("****************************************************");
            Console.WriteLine("\n\n");
            string num = Console.ReadLine();
            while (true)
            {
                switch (num)
                {
                    case "1":
                        Console.WriteLine("choose department");
                        Console.WriteLine("a.orthopedic");
                        Console.WriteLine("b.dental");
                        Console.WriteLine("c.general medicine");
                        Console.WriteLine("\n");
                        num = Console.ReadLine();
                        switch (num)
                        {
                            case "a":
                                ps.orthopedic();
                                break;

                            case "b":
                                ps.dental();
                                break;

                            case "c":
                                ps.generalMedicine();
                                break;

                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                        break;


                    case "2":
                        Console.WriteLine("enter id that you want to update");
                        int a = int.Parse(Console.ReadLine());
                        ps.updateData(a);
                        Console.WriteLine("do you want to print all details");
                        Console.WriteLine(" tpye y/n");
                        string aa = Console.ReadLine();
                        if (aa == "y")
                        {
                            alldetails();
                        }

                        break;

                    case "3":
                        Console.WriteLine("enter id that you want to delete");
                        int b = int.Parse(Console.ReadLine());
                        ps.deleteData(b);
                        break;
                    case "4":
                        Console.WriteLine("enter id that you want to search");
                        int c = int.Parse(Console.ReadLine());
                        ps.search(c);
                        break;
                    case "5":
                        patientRegistration obj = new patientRegistration();
                        Random random = new Random();

                        int p = random.Next(5, 100);

                        Console.WriteLine("your id is " + p);
                    loop:
                        Console.WriteLine("enter your first name");
                        string q = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(q))
                        {
                            Console.WriteLine("enter valid name");
                            goto loop;
                        }

                        foreach (char i in q)
                        {
                            if (char.IsDigit(i))
                            {
                                Console.WriteLine("digit not allowed");
                                goto loop;
                                //break;

                            }
                        }

                        Console.WriteLine("enter your last name");
                        string r = Console.ReadLine();
                    again:
                        Console.WriteLine("enter gender male ,female,other");
                        string u = Console.ReadLine();
                        if (u == "male" || u == "female" || u == "other")
                        {
                            Console.WriteLine();



                        }
                        else
                        {
                            Console.WriteLine("invalid ,plz enter again");
                            goto again;


                        }

                    ash:
                        Console.WriteLine("enter your aadhar number");
                        string v = Console.ReadLine();

                        if (v.Length != 12)
                        {
                            Console.WriteLine("enter valid detail ");
                            goto ash;
                        }
                        foreach (var i in v)
                        {
                            if (!char.IsDigit(i))
                            {
                                Console.WriteLine("enter valid aadhar number");
                                goto ash;
                            }

                        }


                        Console.WriteLine("enter your address");
                        string w = Console.ReadLine();


                    san:
                        Console.WriteLine("enter your age");
                        int x = int.Parse(Console.ReadLine());

                        if (x < 0 || x > 110)
                        {
                            Console.WriteLine("enter valid age");
                            goto san;
                        }



                        Console.WriteLine("enter which specialist you want to visited");

                        string y = Console.ReadLine();
                        switch (y)
                        {

                        }
                    pool:
                        Console.WriteLine("enter your phone number");
                        string z = Console.ReadLine();
                        if (z.Length != 10)
                        {
                            Console.WriteLine("enter valid phone number");
                            goto pool;
                        }
                        foreach (var i in z)
                        {
                            if (!char.IsDigit(i))
                            {
                                Console.WriteLine("enter valid phone number");
                                goto pool;
                            }

                        }




                        obj.P_Id = p;
                        obj.F_Name = q;
                        obj.L_Name = r;
                        obj.gender = u;
                        obj.aadharNo = v;
                        obj.address = w;
                        obj.age = x;
                        obj.speciaist = y;
                        obj.phoneNo = z;

                        ps.createData(obj);
                        Console.WriteLine("do you want to print all details");
                        Console.WriteLine(" tpye y/n");
                        string j = Console.ReadLine();
                        if (j == "y")
                        {
                            alldetails();
                        }

                        break;
                    case "6":
                        alldetails();
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("do you want to continue");
                Console.WriteLine(" tpye y/n");
                string k = Console.ReadLine();
                if (k == "y")
                {
                    Main();
                }
                else
                {
                    break;
                }

                Console.ReadLine();


            }
        }

    }
}