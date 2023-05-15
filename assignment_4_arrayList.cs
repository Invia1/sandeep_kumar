
using System;
using System.Collections;
public class arrayL

{
    ArrayList arrList = new ArrayList();
    public void myList()
    {

        arrList.Add(5);
        arrList.Add("Sandeep");
        arrList.Add(50.36);
        arrList.Add(true);
        arrList.Add("delhi");
        Console.WriteLine("original array : ");
        Console.Write("\n\n");
        Console.WriteLine("---------------------------------------------------------------");
        foreach (var i in arrList)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("total element in  original array " + arrList.Count);

    }

    public void insert()
    {

        arrList.Insert(2, 74);

        arrList.Insert(1, "san");
        arrList.Insert(5, "noida");
        arrList.Insert(6, "mca");
        arrList.Insert(7, 500000);

        Console.Write("array after inserting element: ");
        Console.Write("\n\n");


        Console.WriteLine("---------------------------------------------------------------");

        foreach (var i in arrList)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("total element array  after insertion  " + arrList.Count);
    }

    public void remove()
    {

        arrList.Remove(500000);
        arrList.Remove(true);
        Console.Write("array after removing element: ");
        Console.Write("\n\n");

        Console.WriteLine("---------------------------------------------------------------");
        foreach (var i in arrList)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("total element in array after removing element " + arrList.Count);

    }

    public void search()
    {

        var a = arrList.Contains("mca");
        Console.Write("\n\n");
        if (a == true)
        {
            Console.WriteLine("element found");
        }
        else
        {
            Console.WriteLine("element  not found");

        }
        Console.Write("\n\n");

    }
    public void update(int i, string n)
    {
        arrList.RemoveAt(i);

        arrList.Insert(i, n);
    }
    public void fetchall()
    {
        foreach (var i in arrList)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("total element after all operation " + arrList.Count);
    }


}

public class main
{
    public static void Main()

    {
        var obj = new arrayL();
        obj.myList();
        obj.insert();
        obj.remove();
        obj.search();
        obj.update(3, "suro");
        obj.fetchall();
    }
}



