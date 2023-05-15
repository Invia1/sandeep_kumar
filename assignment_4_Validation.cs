public class food
{
    public string? name { get; set; }
    public int sID { get; set; }
    public string wings { get; set; }
    public string lunchBox { get; set; }
}

public class Fmanager
{
    public food foodDetails()
    {

        var obj = new food();
        int a;

    pool:
        {
            try
            {


                Console.WriteLine("enter your ID");
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("plz enter valid id");
                goto pool;
            }

        }

        obj.sID = a;

    loop:
        {
            Console.WriteLine("enter your name");
            string b = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(b))
            {
                Console.WriteLine("name should not be empty");
                goto loop;
            }


            foreach (char i in b)
            {


                if (char.IsDigit(i))
                {
                    Console.WriteLine("digit not allowed");

                    Console.WriteLine("enter again");
                    goto loop;

                }






            }


            obj.name = b;

        }

        Console.WriteLine("enter your hostel wings");
        string c = Console.ReadLine();
        obj.wings = c;
        Console.WriteLine("want lunch box yes/no");
        string d = Console.ReadLine();
        obj.lunchBox = d;
        return obj;


    }
}



public class student
{
    public static void Main()
    {
        var obj = new Fmanager();
        food temp = obj.foodDetails();
        Console.WriteLine("Id" + "  " + "stuName" + "  " + "hostelWing" + "  " + "wantLunchBox");
        Console.WriteLine(temp.sID + "   " + temp.name + "     " + temp.wings + "    \t  " + temp.lunchBox);
        Console.WriteLine("order booked");

    }
}


