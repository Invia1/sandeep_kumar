using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using DAY8.models;

namespace DAY8.service
{
    public class EmployeeOperation
    {
        List<Employee> objList = new List<Employee>();
        public int CreateEmployee(Employee emp)
        {
            objList.Add(emp);
            return 1;
        }
        public List<Employee> GetEmployeeList()
        {
            return objList;
        }

        public void searchEmployee(int id)
        {

            int a = 0;
            foreach (var item in objList)
            {
                if (item.EID==id)
                {
                    Console.WriteLine("record found");
                    a++;
                }
                
            }
            if(a==0)
            {
                Console.WriteLine("record not found");
            }

         

        }

        public void updateEmployee(int id)
        {
            int b = 0;
            foreach (var a in objList)
            {
                if (a.EID == id)
                {

                    a.Ename = "puspa";
                    a.Age = 32;
                    b++;
                    Console.WriteLine("record updated");
                   
                }
                

            }
            if (b == 0)
            {
                Console.WriteLine("record not found so not able to update");
            }



        }

        public void deleteEmployee(int ID)
        {
            int a = 0;
            foreach (var b in objList)              // here a is of employee type
            {
                if (b.EID == ID)
                {
                    objList.Remove(b);
                    Console.WriteLine(" record deleted");
                    a++;
                    break;
                }

               
            }
            if (a==0)
            {
                Console.WriteLine("record not found so not able to delete");
            }
            





        }


    }
}