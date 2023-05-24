using Hospital_Management_System.functionality;
using Hospital_Management_System.model;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace Hospital_Management_System.service
{
    public class patientService: Ipatient
    {
        List<patientRegistration> PList = new List<patientRegistration>();
        public int createData(patientRegistration p)
        {
            PList.Add(p);
            return 1;
        }
        
        public IEnumerable<patientRegistration> GetData()
        {
            return PList;
        }

        public void updateData(int n)
        {
            int a = 0;
            foreach(var i in PList)
            {
             if(i.P_Id==n)
                {loop:
                    Console.WriteLine("enter your first name");
                    string q = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(q))
                    {
                        Console.WriteLine("enter valid name");
                        goto loop;
                    }
                    foreach (char ii in q)
                    {
                        if (char.IsDigit(ii))
                        {
                            Console.WriteLine("digit not allowed");
                            goto loop;
                            //break;

                        }
                    }
                    Console.WriteLine("enter your last name");
                    string r = Console.ReadLine();
                    Console.WriteLine("enter gender");
                    string u = Console.ReadLine();
                    Console.WriteLine("enter your aadhar number");
                    string v = Console.ReadLine();
                    Console.WriteLine("enter your address");
                    string w = Console.ReadLine();
                    Console.WriteLine("enter your age");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter whic specialist you want to visited");
                    string y = Console.ReadLine();
                    pool:
                    Console.WriteLine("enter your phone number");
                    string z = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(z))
                    {
                        Console.WriteLine("enter valid phone number");
                        goto pool;
                    }


                    i.F_Name = q;
                    i.L_Name = r;
                    i.gender = u;
                    i.aadharNo = v;
                    i.address = w;
                    i.age = x;
                    i.speciaist = y;
                    i.phoneNo = z;
                    Console.WriteLine("1 item is updated");
                    a++;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("data doesn't exist");
            }
        }

        public void deleteData(int n) 
        {
            int a = 0;
            foreach (patientRegistration i in PList)
            {
                if (i.P_Id == n)
                {

                 PList.Remove(i);
                    Console.WriteLine("1 item is removed");
                    a++;
                    break;

                }
            }
            if(a==0)
            {
                Console.WriteLine("data doesn't exist");
            }
        }
        public void search(int n)
        {
            int a = 0;
            foreach (patientRegistration i in PList)
            {
                if (i.P_Id== n)
                {

                    
                    Console.WriteLine("data found");
                    a++;
                    break;

                }
            }
            if (a == 0)
            {
                Console.WriteLine("data doesn't found");
            }
        }

        public void orthopedic()
        {
            Console.WriteLine("////////////////////////////////////////////////");
            Console.WriteLine("welcome to orthopedic department of RIM Hospital");
            Console.WriteLine("////////////////////////////////////////////////");
            Console.WriteLine("\n");
            Console.WriteLine("tell us about your problem");
            string ss = Console.ReadLine();
            Console.WriteLine("enter your name ");
            string s = Console.ReadLine();
            Console.WriteLine("enter your appointment day ");
            string t = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("--------------**************------------------");
            Console.WriteLine($"your name is {s} and appointment day is {t} for orthopedic problem {ss}");
            Console.WriteLine("thank you");
            Console.WriteLine("--------------**************------------------");
            
        }

        public void generalMedicine()
        {
            Console.WriteLine("//////////////////////////////////////////////////////");
            Console.WriteLine("welcome to general medicine department of RIM Hospital ");
            Console.WriteLine("///////////////////////////////////////////////////////");
            Console.WriteLine("\n");
            Console.WriteLine("tell us about your problem");
            string ss = Console.ReadLine();
            Console.WriteLine("enter your name ");
            string s = Console.ReadLine();
            Console.WriteLine("enter your appointment day ");
            string t = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("-------------**************--------------------");
            Console.WriteLine($"your name is {s} and appointment day is {t} for your problrm {ss} in general medicine");


            Console.WriteLine("thank you");
            Console.WriteLine("--------------**************--------------------");
          
        }

        public void dental()
        {
            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine("welcome to dental department of RIM Hospital");
            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine("tell us about your problem");
            Console.WriteLine("\n");
            string ss = Console.ReadLine();
            Console.WriteLine("enter your name ");
            string s = Console.ReadLine();
            Console.WriteLine("enter your appointment day ");
            string t = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("------- -------**************------------------------");
            Console.WriteLine($"your name is {s} and appointment day is {t} for dental problem {ss}");
            Console.WriteLine("thank you");
            Console.WriteLine("----------------**************-----------------------");
            
        }

        
    }
}
