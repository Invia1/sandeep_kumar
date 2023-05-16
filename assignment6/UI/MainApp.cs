using System;
using DAY8.models;
using DAY8.service;


namespace DAY8.UI
{
    public class MainApp
    {
        public static void Main()
        {

           


            Employee obj= new Employee();
            obj.EID= 101;
            obj.Ename = "sandeep";
            obj.Age = 22;

            Employee obj1= new Employee();
            obj1.EID = 102;
            obj1.Ename = "san";
            obj1.Age = 20;

            Employee obj2 = new Employee();
            obj2.EID = 1034;
            obj2.Ename = "sandy";
            obj2.Age = 24;

            Employee obj3 = new Employee();
            obj3.EID = 104;
            obj3.Ename = "deep";
            obj3.Age = 29;

            EmployeeOperation es=new EmployeeOperation();
            es.CreateEmployee(obj);
            es.CreateEmployee(obj1);
            es.CreateEmployee(obj2);
            es.CreateEmployee(obj3);


            es.updateEmployee(102);
            es.searchEmployee(102);
            es.deleteEmployee(103);



            List<Employee> objList= es.GetEmployeeList();
            Console.WriteLine("ID" + "\t\t" + "name" + "\t\t" + "age");
            foreach (var data in objList)
            {
                //Console.WriteLine("ID" + "\t\t"+ "name" + "\t\t" + "age");
                Console.WriteLine(data.EID + "\t\t" + data.Ename + "\t\t" + data.Age);
                
            }


        }

    }
}
