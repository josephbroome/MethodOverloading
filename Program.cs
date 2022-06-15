// See https://aka.ms/new-console-template for more information
class Program
{

    static void Main(string[] args)
    {
       Console.WriteLine (Add(1, 6, true));
        Console.WriteLine (Add(25.5, 17.8, true));
        Console.WriteLine(Add(10, 10));


       
        Console.WriteLine(Add(5.66, 6.66));

        Console.WriteLine(Add(7, 8, 9));
        Console.WriteLine(Add(20, 22));
     

    }

    public static double Add(double x,double y)
    {

        return x + y;

    }

    public static double Add(double x, double y, double z)
    {
        return x +y +z;
       

    }


    public static string Add(double num1, double num2, bool isCheck)
    {
        var sum = num1 + num2;

        if (isCheck==true && sum>1)
        {
            return $"{sum} dollars";

        }
        else if (isCheck==true && sum==1)
        {
            return $"{sum} dollar";

        }
        else if (isCheck == true && sum<1)
        {
            return $"{sum} dollars";
        }
        else
        {
            return sum.ToString();
        }


    }



}
