
using System;
using System.Collections;
using System.Collections.Generic;
class Glist
{
    List<string> obj = new List<string>();
  
    public void addList()
    {

        obj.Add("sandeep");
        obj.Add("umesh");
        obj.Add("pawan");
        obj.Add("Anand");

        foreach (var i in obj)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("total element in  original array " + obj.Count);
    }

    public void insertList()
    {
        obj.Insert(2,"rakhi");
        obj.Insert(5,"kittu");
        obj.Insert(4,"san");
        foreach (var i in obj)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("total element in  inserted array " + obj.Count);

    }

    public void delList()
    {
        obj.Remove("rakhi");
        obj.Remove("san");

        foreach (var i in obj)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("total element after deletion array " + obj.Count);

    }
    public void update(int i,string n)
    {
        obj.RemoveAt(i);

        obj.Insert(i,n);
    }

    public void search()
    {
        var a = obj.Contains("sandeep");
        if(a==true)
        {
            Console.WriteLine("element found");
        }
        else
        {
            Console.WriteLine("element  not found");

        }
    }
    public void fetchall()
    {
        foreach (var i in obj)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("total element after all operation " + obj.Count);
    }
   
 }






class main
{
    public static void Main()
    {
        var obj= new Glist();
        obj.addList();
    obj.insertList();
    obj.delList();
    obj.search();
        obj.update(2, "suro");
        obj.fetchall();
    }
}

