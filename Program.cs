using System; 
namespace ProgramLabShum
{
    class Program{

    static void Main(string[] args)
    {
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());
        double answer = 2*Math.Sin(x)+3*Math.Cos(x);
        Console.WriteLine(answer);
        Console.ReadLine();
    }


    }
}