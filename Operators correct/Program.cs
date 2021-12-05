using System;

namespace Operators
{

}
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("birinci ededi daxil edin : ");
        int fNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("ikinci ededi daxil edin : ");
        int sNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("operator daxil edin : ");
        string optr = Console.ReadLine();

        switch (optr)
        {
            case "+":
                Console.WriteLine(fNum + sNum);
                break;
            case "-":
                Console.WriteLine(fNum - sNum);
                break;
            case "*":
                Console.WriteLine(fNum * sNum);
                break;
            case "/":
                Console.WriteLine(fNum / sNum);
                break;
            default:
                Console.WriteLine("incorrect operator");
                break;

        }
    }
}





